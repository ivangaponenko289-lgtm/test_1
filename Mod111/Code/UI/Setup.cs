using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ModernBoxShitty : MonoBehaviour
{
    private Canvas canvas;
    private RectTransform contentContainer;
    private List<GameObject> tabs = new List<GameObject>();
    private int currentTabIndex = 0;

    private Color themeWhite = Color.white;
    private Color themeBlack = new Color(0.1f, 0.1f, 0.1f);
    private Color themeButtonDefault = new Color(0.9f, 0.9f, 0.9f);
    private Color themeButtonSelected = new Color(0.7f, 0.9f, 0.7f);
    private Font mainFont;

    private List<Image> eraButtonImages = new List<Image>();
    private List<Image> updateButtonImages = new List<Image>();

    void Start()
    {
        ModernBoxPrefs.Load();
        mainFont = Resources.GetBuiltinResource<Font>("Arial.ttf");
        
        CreateRequiredSystems();
        CreateCanvas();
        CreateBackground();
        CreateMainPanel();
        
        BuildTab1(); 
        BuildTab2(); 
        BuildTab3(); 
        BuildTab4(); 
        
        UpdateTabPositions();
        RefreshVisualSelections();
    }

    void CreateRequiredSystems()
    {
        if (FindObjectOfType<EventSystem>() == null)
        {
            GameObject es = new GameObject("EventSystem");
            es.AddComponent<EventSystem>();
            es.AddComponent<StandaloneInputModule>();
        }
    }

    void CreateCanvas()
    {
        GameObject canvasObj = new GameObject("ModernBoxCanvas");
        canvas = canvasObj.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvas.sortingOrder = 999;
        canvasObj.AddComponent<CanvasScaler>().uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        canvasObj.AddComponent<GraphicRaycaster>();
    }

    void CreateBackground()
    {
        GameObject bg = new GameObject("BlackoutBG");
        bg.transform.SetParent(canvas.transform, false);
        Image img = bg.AddComponent<Image>();
        img.color = Color.black;
        RectTransform rt = bg.GetComponent<RectTransform>();
        rt.anchorMin = Vector2.zero; rt.anchorMax = Vector2.one; rt.sizeDelta = Vector2.zero;
    }

    void CreateMainPanel()
    {
        GameObject panel = new GameObject("MainPanel");
        panel.transform.SetParent(canvas.transform, false);
        RectTransform rt = panel.AddComponent<RectTransform>();
        rt.sizeDelta = new Vector2(600, 500);

        Image img = panel.AddComponent<Image>();
        img.sprite = CreateRoundedSprite(64);
        img.type = Image.Type.Sliced;
        img.color = themeWhite;

        GameObject viewport = new GameObject("Viewport");
        viewport.transform.SetParent(panel.transform, false);
        RectTransform vprt = viewport.AddComponent<RectTransform>();
        vprt.anchorMin = Vector2.zero; vprt.anchorMax = Vector2.one;
        vprt.sizeDelta = new Vector2(-40, -40);
        viewport.AddComponent<Image>(); 
        viewport.AddComponent<Mask>().showMaskGraphic = false;

        GameObject content = new GameObject("Content");
        content.transform.SetParent(viewport.transform, false);
        contentContainer = content.AddComponent<RectTransform>();
        contentContainer.anchorMin = Vector2.zero; contentContainer.anchorMax = Vector2.one;
        contentContainer.sizeDelta = Vector2.zero;
    }

    #region Tabs

    void BuildTab1()
    {
        GameObject tab = CreateTabObject("WelcomeTab");
        AddText(tab, "Welcome to ModernBox", 34, true, new Vector2(0, 150));
        AddText(tab, "Version 4.05", 20, false, new Vector2(0, 100));
        AddButton(tab, "NEXT", new Vector2(0, -180), NextTab);
    }

    void BuildTab2()
    {
        GameObject tab = CreateTabObject("ErasTab");
        AddText(tab, "Eras", 30, true, new Vector2(0, 180));
        AddText(tab, "How long would you like it to take for kingdoms to progress to modern technology?", 16, false, new Vector2(0, 135), new Vector2(520, 80));

        string[] titles = { "Very Early", "Some Time", "Realism" };
        string[] descs = { "Modern weapons and vehicles basically immediately.", "Takes 50 to 200 years. Ancient tech arrives first.", "Could take kingdoms thousands of years." };
        float[][] values = { 
            new float[] { 0, 20, 0, 150 }, 
            new float[] { 100, 120, 0, 700 }, 
            new float[] { 1000, 1200, 0, 2000 } 
        };

        for (int i = 0; i < 3; i++)
        {
            int index = i;
            GameObject btn = AddEraButton(tab, titles[i], descs[i], new Vector2(-180 + (i * 180), 0), () => SelectEra(index, values[index]));
            eraButtonImages.Add(btn.GetComponent<Image>());
        }

        AddButton(tab, "NEXT", new Vector2(0, -180), NextTab);
    }

    void BuildTab3()
    {
        GameObject tab = CreateTabObject("UpdateTab");
        AddText(tab, "Update Checker", 30, true, new Vector2(0, 180));
        AddText(tab, "Would you like to receive notices when a newer version is available?\n(NOTE: Unnecessary for Steam Workshop users)", 16, false, new Vector2(0, 100), new Vector2(500, 100));

        GameObject yesBtn = AddButton(tab, "YES", new Vector2(-100, -20), () => SelectUpdate(true));
        GameObject noBtn = AddButton(tab, "NO", new Vector2(100, -20), () => SelectUpdate(false));
        
        updateButtonImages.Add(yesBtn.GetComponent<Image>());
        updateButtonImages.Add(noBtn.GetComponent<Image>());

        AddButton(tab, "SAVE & NEXT", new Vector2(0, -180), () => { ModernBoxPrefs.Save(); NextTab(); });
    }

    void BuildTab4()
    {
        GameObject tab = CreateTabObject("RestartTab");
        AddText(tab, "Restart Required", 30, true, new Vector2(0, 180));
        AddText(tab, "This UI uses a very dumb system where it disables everything else in the game, so please exit and reboot.", 16, false, new Vector2(0, 100), new Vector2(500, 100));
        AddButton(tab, "EXIT GAME", new Vector2(0, -180), Application.Quit);
    }

    #endregion

    #region Logic & Visual Updates

    void SelectEra(int index, float[] vals)
    {
        ModernBoxPrefs.EraProgress = vals;
        for (int i = 0; i < eraButtonImages.Count; i++)
            eraButtonImages[i].color = (i == index) ? themeButtonSelected : themeButtonDefault;
    }

    void SelectUpdate(bool val)
    {
        ModernBoxPrefs.Updates = val;
        updateButtonImages[0].color = val ? themeButtonSelected : themeButtonDefault;
        updateButtonImages[1].color = !val ? themeButtonSelected : themeButtonDefault;
    }

    void RefreshVisualSelections()
    {
        SelectEra(1, new float[] { 100, 120, 0, 700 });
        SelectUpdate(true);
    }

    #endregion

    #region Helpers

    GameObject CreateTabObject(string name)
    {
        GameObject tab = new GameObject(name);
        tab.transform.SetParent(contentContainer, false);
        RectTransform rt = tab.AddComponent<RectTransform>();
        rt.anchorMin = Vector2.zero; rt.anchorMax = Vector2.one; rt.sizeDelta = Vector2.zero;
        tabs.Add(tab);
        return tab;
    }

    void AddText(GameObject parent, string text, int size, bool bold, Vector2 pos, Vector2? area = null)
    {
        GameObject txtObj = new GameObject("Txt");
        txtObj.transform.SetParent(parent.transform, false);
        Text t = txtObj.AddComponent<Text>();
        t.text = text; t.font = mainFont; t.fontSize = size; t.color = themeBlack;
        t.alignment = TextAnchor.MiddleCenter;
        t.fontStyle = bold ? FontStyle.Bold : FontStyle.Normal;
        
        t.horizontalOverflow = HorizontalWrapMode.Wrap;
        t.verticalOverflow = VerticalWrapMode.Truncate;

        RectTransform rt = txtObj.GetComponent<RectTransform>();
        rt.anchoredPosition = pos;
        rt.sizeDelta = area ?? new Vector2(550, 50);
    }

    GameObject AddButton(GameObject parent, string label, Vector2 pos, UnityEngine.Events.UnityAction onClick)
    {
        GameObject btnObj = new GameObject("Btn_" + label);
        btnObj.transform.SetParent(parent.transform, false);
        
        Image img = btnObj.AddComponent<Image>();
        img.sprite = CreateRoundedSprite(32);
        img.type = Image.Type.Sliced;
        img.color = themeButtonDefault;

        Button b = btnObj.AddComponent<Button>();
        b.onClick.AddListener(onClick);

        RectTransform rt = btnObj.GetComponent<RectTransform>();
        rt.anchoredPosition = pos;
        rt.sizeDelta = new Vector2(150, 50);

        if (!string.IsNullOrEmpty(label))
            AddText(btnObj, label, 18, true, Vector2.zero, new Vector2(150, 50));

        return btnObj;
    }

    GameObject AddEraButton(GameObject parent, string title, string desc, Vector2 pos, UnityEngine.Events.UnityAction onClick)
    {
        GameObject btn = AddButton(parent, "", pos, onClick);
        btn.GetComponent<RectTransform>().sizeDelta = new Vector2(170, 180);
        AddText(btn, title, 17, true, new Vector2(0, 60), new Vector2(150, 30));
        AddText(btn, desc, 12, false, new Vector2(0, -20), new Vector2(150, 110));
        return btn;
    }

    void UpdateTabPositions()
    {
        for (int i = 0; i < tabs.Count; i++)
            tabs[i].GetComponent<RectTransform>().anchoredPosition = new Vector2(i * 1000, 0); 
    }

    public void NextTab()
    {
        if (currentTabIndex < tabs.Count - 1)
        {
            currentTabIndex++;
            StopAllCoroutines();
            StartCoroutine(SlideToTab(currentTabIndex));
        }
    }

    IEnumerator SlideToTab(int index)
    {
        Vector2 startPos = contentContainer.anchoredPosition;
        Vector2 targetPos = new Vector2(-index * 1000, 0);
        float time = 0;
        while (time < 0.5f)
        {
            contentContainer.anchoredPosition = Vector2.Lerp(startPos, targetPos, Mathf.SmoothStep(0, 1, time / 0.5f));
            time += Time.deltaTime;
            yield return null;
        }
        contentContainer.anchoredPosition = targetPos;
    }

    Sprite CreateRoundedSprite(int size)
    {
        Texture2D tex = new Texture2D(size, size);
        float radius = size / 2.1f;
        Vector2 center = new Vector2(size / 2f, size / 2f);
        for (int y = 0; y < size; y++)
            for (int x = 0; x < size; x++)
                tex.SetPixel(x, y, Vector2.Distance(new Vector2(x, y), center) <= radius ? Color.white : Color.clear);
        tex.Apply();
        return Sprite.Create(tex, new Rect(0, 0, size, size), Vector2.one * 0.5f, 100, 0, SpriteMeshType.Tight, new Vector4(radius, radius, radius, radius));
    }
    #endregion
}