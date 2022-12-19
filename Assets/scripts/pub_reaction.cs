using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RosSharp.RosBridgeClient
{
    public class pub_reaction : UnityPublisher<MessageTypes.Std.Float32MultiArray>
    {
        public Slider slider_reaction_skin, slider_reaction_face, slider_reaction_voice;
        private MessageTypes.Std.Float32MultiArray message;

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
            message = new MessageTypes.Std.Float32MultiArray();
            message.data = new float[3];
        }
        private void UpdateMessage()
        {
            message.data[0] = float.Parse(slider_reaction_skin.value.ToString("0.00"));
            message.data[1] = float.Parse(slider_reaction_face.value.ToString("0.00"));
            message.data[2] = float.Parse(slider_reaction_voice.value.ToString("0.00"));

            Publish(message);
        }
        public void OnClickButton_Reaction()
        {
        UpdateMessage();
        }
    }
}
