using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class slide_controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider_input_skin, slider_input_face, slider_input_voice;
    public Slider slider_reaction_skin, slider_reaction_face, slider_reaction_voice;
    public TextMeshProUGUI show_input_skin, show_input_face, show_input_voice;
    public TextMeshProUGUI show_reaction_skin, show_reaction_face, show_reaction_voice;
    
    float input_skin, input_face, input_voice;
    float reaction_skin, reaction_face, reaction_voice;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        input_skin = float.Parse(slider_input_skin.value.ToString("0.00"));
        show_input_skin.text = "Input(Skin): "+input_skin;
        
        input_face = float.Parse(slider_input_face.value.ToString("0.00"));
        show_input_face.text = "Input(Face): "+input_face;
        
        input_voice = float.Parse(slider_input_voice.value.ToString("0.00"));
        show_input_voice.text = "Input(Voice): "+input_voice;
        
        reaction_skin = float.Parse(slider_reaction_skin.value.ToString("0.00"));
        show_reaction_skin.text = "Reaction(Skin): "+reaction_skin;
        
        reaction_face = float.Parse(slider_reaction_face.value.ToString("0.00"));
        show_reaction_face.text = "Reaction(Face): "+reaction_face;
        
        reaction_voice = float.Parse(slider_reaction_voice.value.ToString("0.00"));
        show_reaction_voice.text = "Reaction(Voice): "+reaction_voice;
        
    }
}
