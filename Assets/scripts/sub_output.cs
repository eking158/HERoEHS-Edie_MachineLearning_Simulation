//rostopic pub /edie/output  -1  std_msgs/Int32MultiArray "data: [1, 8, 2]" 

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
        float edie_face, edie_motion, edie_voice;
        string[] face_mod = {	" ", 
        			"face mod1", 
        			"face mod2",
        			"face mod3",
        			"face mod4"};
        string[] motion_mod = {" ", 
        			"motion mod1", 
        			"motion mod2",
        			"motion mod3",
        			"motion mod4"};
        string[] voice_mod = { " ", 
        			"voice mod1", 
        			"voice mod2",
        			"voice mod3",
        			"voice mod4"};

        protected override void Start()
        {
            base.Start();
        }

        protected override void ReceiveMessage(MessageTypes.Std.Int32MultiArray message)
        {
            edie_face = message.data[0];
            edie_motion = message.data[1];
            edie_voice = message.data[2];
            isMessageReceived = true;
        }

        private void Update()
        {
            if (isMessageReceived)
                ProcessMessage();
        }
        
        private void ProcessMessage()
        {
            show_edie_datas.text =     "Edie Face: "+edie_face+" ("+face_mod[(int)edie_face]+")"+"\n"+
            				"Edie Motion: "+edie_motion+" ("+motion_mod[(int)edie_motion]+")"+"\n"+
            				"Edie Voice: "+edie_voice+" ("+voice_mod[(int)edie_voice]+")";
            				
            Debug.Log("Got Message");
            
            PlayFace((int)edie_face);
            PlayMotion((int)edie_motion);
            PlayVoice((int)edie_voice);

            isMessageReceived = false;
        }
        //----------------------------------------------------------------------------------------------
        private void PlayFace(int mod){
            switch(mod){
                case 0:
                break;
                
                case 1:
                break;
            }
        }
        //----------------------------------------------------------------------------------------------
        private void PlayMotion(int mod){
            switch(mod){
                case 0:
                break;
                
                case 1:
                break;
            }
        }
        //----------------------------------------------------------------------------------------------
        private void PlayVoice(int mod){
            switch(mod){
                case 0:
                break;
                
                case 1:
                break;
            }
        }
    }
}
