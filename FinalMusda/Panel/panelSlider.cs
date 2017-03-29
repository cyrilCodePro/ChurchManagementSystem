using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Transitions;

namespace FinalMusda.Panel
{
    public partial class panelSlider : MetroFramework.Controls.MetroUserControl
    {
        Form _Owner =null;
        bool _Loaded = false;
        #region Events
        public event EventHandler Closed;
        public event EventHandler Shown;
        protected virtual void closed(EventArgs e)
        {
            EventHandler handler = Closed;
            if (handler != null) handler(this, e);
        }
        protected virtual void shown(EventArgs e)
        {
            EventHandler handler = Shown;
            if (handler != null) handler(this, e);
        }
        #endregion
        public panelSlider()
        {
            InitializeComponent();
        }
        public panelSlider(Form Owner):this()
        {
            this.Visible = false;
            _Owner = Owner;
            Owner.Controls.Add(this);
            this.BringToFront();
            Owner.Resize += Owner_Resize;
            this.Click += PanelSlider_Click;
            ResizeForm();
        }

        private void PanelSlider_Click(object sender, EventArgs e)
        {
            swipe(false);
        }

        private void Owner_Resize(object sender, EventArgs e)
        {
            ResizeForm();
        }
        private void ResizeForm()
        {
            this.Width = _Owner.Width;
            this.Height = _Owner.Height;
            this.Location = new Point(_Loaded ? 0 : _Owner.Width, 50);
        }
        public void swipe(bool show=true)
        {
            this.Visible = true;
            Transition _transition = new Transitions.Transition(new TransitionType_EaseInEaseOut(2000));
            _transition.add(this, "Left", show ? 0 :this.Width);
            _transition.run();
            if (!show)
            {
                closed(new EventArgs());
                _Owner.Resize -= Owner_Resize;
                _Owner.Controls.Remove(this);
                this.Dispose();
            }
            else
            {
                _Loaded = true;
                ResizeForm();
                shown(new EventArgs());
            }
        }
    }
}
