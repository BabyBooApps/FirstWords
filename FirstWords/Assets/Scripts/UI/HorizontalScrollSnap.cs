using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HorizontalScrollSnap : MonoBehaviour
{
    public RectTransform contentPanel;
    public float snapSpeed = 10f;
    public Button nextButton;
    public Button prevButton;

    public float snappedScale = 0.5f;
    public float otherScale = 0.3f;

    private ScrollRect scrollRect;
    private RectTransform[] menuItems;
    private int currentItemIndex = 0;
    private bool isScrolling = false;
    private bool initialMove = true;  // Flag to track initial movement
    private bool isCoroutineRunning = false;  // Flag to track if the coroutine is currently running

    private float tilesSpacing = -460; // Default spacing

    private void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
        InitializeMenuItems();
        initialMove = true;  // Set initialMove to true to ensure the initial snap

        tilesSpacing = CalculateSpacing();

        if (nextButton != null)
        {
            nextButton.onClick.AddListener(ScrollToNext);
        }

        if (prevButton != null)
        {
            prevButton.onClick.AddListener(ScrollToPrevious);
        }

        UpdateButtonVisibility();


    }

    private void InitializeMenuItems()
    {
        int childCount = contentPanel.childCount;
        menuItems = new RectTransform[childCount];

        for (int i = 0; i < childCount; i++)
        {
            menuItems[i] = contentPanel.GetChild(i) as RectTransform;
        }
    }

    private void Update()
    {
        if (!isScrolling)
        {
            SnapToCenter();
        }
    }

    private void SnapToCenter()
    {
        if (initialMove)
        {
            // If it's the initial move, set the content position to the first item without snapping
            scrollRect.content.anchoredPosition = new Vector2(-menuItems[0].anchoredPosition.x, scrollRect.content.anchoredPosition.y);
            SetItemScale(menuItems[0], snappedScale);
            currentItemIndex = 0;  // Set the currentItemIndex to 0
            initialMove = false;  // Disable initialMove after the first snap
            UpdateButtonVisibility();
        }
        else
        {
            // Otherwise, perform the regular snap to center behavior
            float spacing = tilesSpacing; // Use dynamically calculated spacing
            float targetX = -menuItems[currentItemIndex].anchoredPosition.x - spacing; // Compensate for spacing
            Vector2 targetPosition = new Vector2(targetX, scrollRect.content.anchoredPosition.y);
            scrollRect.content.anchoredPosition = Vector2.Lerp(scrollRect.content.anchoredPosition, targetPosition, snapSpeed * Time.deltaTime);

            // Lerp the scale for all items based on their distance from the center
            for (int i = 0; i < menuItems.Length; i++)
            {
                float distance = Mathf.Abs(scrollRect.content.anchoredPosition.x + menuItems[i].anchoredPosition.x);
                float scale = (i == currentItemIndex) ? Mathf.Lerp(otherScale, snappedScale, Mathf.Clamp01(1 - (distance / spacing))) : otherScale;
                LerpItemScale(menuItems[i], scale);
            }

            UpdateButtonVisibility();
        }
    }

    private void SetItemScale(RectTransform item, float scale)
    {
        item.localScale = new Vector3(scale, scale, 1f);
    }

    private void LerpItemScale(RectTransform item, float targetScale)
    {
        float scale = Mathf.Lerp(item.localScale.x, targetScale, snapSpeed * Time.deltaTime);
        item.localScale = new Vector3(scale, scale, 1f);
    }

    private void ScrollToNext()
    {
        if (currentItemIndex < menuItems.Length - 1 && !isScrolling && !isCoroutineRunning)
        {
            StartCoroutine(ScrollToIndex(currentItemIndex + 1));
        }
    }

    private void ScrollToPrevious()
    {
        if (currentItemIndex > 0 && !isScrolling && !isCoroutineRunning)
        {
            StartCoroutine(ScrollToIndex(currentItemIndex - 1));
        }
    }

    private System.Collections.IEnumerator ScrollToIndex(int targetIndex)
    {
        isScrolling = true;
        isCoroutineRunning = true;

        float spacing = tilesSpacing; // Use dynamically calculated spacing
        float targetX = -menuItems[targetIndex].anchoredPosition.x - spacing; // Compensate for spacing
        Vector2 targetPosition = new Vector2(targetX, scrollRect.content.anchoredPosition.y);

        while (Vector2.Distance(scrollRect.content.anchoredPosition, targetPosition) > 1f)
        {
            scrollRect.content.anchoredPosition = Vector2.Lerp(scrollRect.content.anchoredPosition, targetPosition, snapSpeed * Time.deltaTime);

            // Lerp the scale for all items based on their distance from the center
            for (int i = 0; i < menuItems.Length; i++)
            {
                float distance = Mathf.Abs(scrollRect.content.anchoredPosition.x + menuItems[i].anchoredPosition.x);
                float scale = (i == targetIndex) ? Mathf.Lerp(otherScale, snappedScale, Mathf.Clamp01(1 - (distance / spacing))) : otherScale;
                LerpItemScale(menuItems[i], scale);
            }

            yield return null;
        }

        currentItemIndex = targetIndex;
        isScrolling = false;
        isCoroutineRunning = false;
        UpdateButtonVisibility();
    }

    private void UpdateButtonVisibility()
    {
        for (int i = 0; i < menuItems.Length; i++)
        {
            Button button = menuItems[i].GetComponent<Button>();

            if (button != null)
            {
                button.interactable = (i == currentItemIndex);

                // Additional logic to disable the button GameObject when not snapped
                //menuItems[i].gameObject.SetActive(i == currentItemIndex);
            }
        }

        if (prevButton != null)
        {
            prevButton.gameObject.SetActive(currentItemIndex > 0);
        }

        if (nextButton != null)
        {
            nextButton.gameObject.SetActive(currentItemIndex < menuItems.Length - 1);
        }
    }

    // Function to calculate spacing dynamically based on aspect ratio
    private float CalculateSpacing()
    {
        float aspectRatio = (float)Screen.width / Screen.height;

        // Mapping of aspect ratios to spacing values with approximate checks
        Dictionary<float, float> aspectRatioMapping = new Dictionary<float, float>()
    {
        { Approximate(20f / 9f), -460f },  // Example rule for 20:9 aspect ratio
        { Approximate(16f / 10f), 380f },   // Example rule for 16:10 aspect ratio
        { Approximate(21f / 18f), -300f },  // Example rule for 21:18 aspect ratio
        // Add more rules as needed
    };

        // Default spacing value for unknown aspect ratios
        float defaultSpacing = -460f;

        // Check if the aspect ratio is in the mapping with approximate checks, otherwise use the default value
        foreach (var mapping in aspectRatioMapping)
        {
            if (Approximate(mapping.Key) == Approximate(aspectRatio))
            {
                return mapping.Value;
            }
        }

        return defaultSpacing;
    }

    // Function to approximate floating-point values for comparison
    private float Approximate(float value, float epsilon = 0.001f)
    {
        return Mathf.Round(value / epsilon) * epsilon;
    }
}
