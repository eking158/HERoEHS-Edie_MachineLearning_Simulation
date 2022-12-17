using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RosSharp.RosBridgeClient
{
    public class pub_input : UnityPublisher<MessageTypes.Std.Int32MultiArray>
    {
        public Slider slider_input_skin, slider_input_face, slider_input_voice;
        private MessageTypes.Std.Int32MultiArray message;

        protected override void Start()
        {
            base.Start();
            InitializeMessage();
        }

        private void FixedUpdate()
        {
        }

        private void InitializeMessage()
        {
            message = new MessageTypes.Std.Int32MultiArray();
            message.data = new int[3];
        }
        private void UpdateMessage()
        {
            message.data[0] = (int)float.Parse(slider_input_skin.value.ToString("0.00"));
            message.data[1] = (int)float.Parse(slider_input_face.value.ToString("0.00"));
            message.data[2] = (int)float.Parse(slider_input_voice.value.ToString("0.00"));

            Publish(message);
        }
        public void OnClickButton_Input()
        {
        UpdateMessage();
        }
    }
}
