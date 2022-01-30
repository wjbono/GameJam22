using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSwitcher : MonoBehaviour
{
    [SerializeField]
    Canvas EmailCanvas;

    [SerializeField]
    Canvas ResultsCanvas;

    public enum Canvases
    {
        EMAIL,
        RESULTS
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCanvas(Canvases can)
    {
        Dictionary<Canvases, Canvas> canv = new Dictionary<Canvases, Canvas>
        {
            {Canvases.EMAIL,EmailCanvas },
            {Canvases.RESULTS, ResultsCanvas }
        };
        Canvas canvas = canv[can];
        EmailCanvas.gameObject.SetActive(false);
        ResultsCanvas.gameObject.SetActive(false);
        canvas.gameObject.SetActive(true);
    }

    public void ShowResult(GameManager.Result result)
    {

    }
}
