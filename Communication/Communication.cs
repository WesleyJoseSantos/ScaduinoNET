using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using ScreenEditor.DataBase;

namespace Communication
{
    public partial class Communication : Component
    {
        private List<ControlTag> tags;
        UInt32 deviceId;

        public List<ControlTag> Tags { get => tags; set => tags = value; }
        public uint DeviceId { get => deviceId; set => deviceId = value; }

        public Communication()
        {
            InitializeComponent();
        }

        public Communication(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public virtual void connect()
        {

        }
    }
}
