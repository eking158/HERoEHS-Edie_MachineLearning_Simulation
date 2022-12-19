//rostopic pub /edie/output  -1  std_msgs/Int32MultiArray "data: [1]" 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace RosSharp.RosBridgeClient
{
    public class sub_output : UnitySubscriber<MessageTypes.Std.Int32MultiArray>
    {
        public TextMeshProUGUI show_edie_datas;
        private bool isMessageReceived;
        float edie_emotion;
        string[] emotion_mod = {	" ", 
        			"emotion mod1", 
        			"emotion mod2",
        			"emotion mod3",
        			"emotion mod4"};

        protected override void Start()
        {
            base.Start();
        }

        protected override void ReceiveMessage(MessageTypes.Std.Int32MultiArray message)
        {
            edie_emotion = message.data[0];
            isMessageReceived = true;
        }

        private void Update()
        {
            if (isMessageReceived)
                ProcessMessage();
        }
        
        private void ProcessMessage()
        {
            show_edie_datas.text =     "EDIE Emotion: "+edie_emotion+" ("+emotion_mod[(int)edie_emotion]+")";
            				
            Debug.Log("Got Message");
            
            PlayEmotion((int)edie_emotion);

            isMessageReceived = false;
        }
        //----------------------------------------------------------------------------------------------
        private void PlayEmotion(int mod){
            switch(mod){
                case 0:
                break;
                
                case 1:
                break;
            }
        }
        //----------------------------------------------------------------------------------------------
    }
}
