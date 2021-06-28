
namespace cafemanagement1
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.LinkLabel();
            this.btnexit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnremove = new Guna.UI2.WinForms.Guna2Button();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnadditems = new Guna.UI2.WinForms.Guna2Button();
            this.btnplaceorder = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.updateitem1 = new cafemanagement1.allusercontrl.updateitem();
            this.placeorderusercontrol1 = new cafemanagement1.allusercontrl.Placeorderusercontrol();
            this.additemusercontrol1 = new cafemanagement1.allusercontrl.additemusercontrol();
            this.userwelcome1 = new cafemanagement1.allusercontrl.userwelcome();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnremove);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnadditems);
            this.panel1.Controls.Add(this.btnplaceorder);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 514);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnlogout
            // 
            this.btnlogout.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.btnlogout, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(73, 409);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(59, 20);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.TabStop = true;
            this.btnlogout.Text = "logout";
            this.btnlogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnlogout_LinkClicked);
            // 
            // btnexit
            // 
            this.btnexit.CheckedState.Parent = this.btnexit;
            this.btnexit.CustomImages.Parent = this.btnexit;
            this.guna2Transition1.SetDecoration(this.btnexit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.HoverState.Parent = this.btnexit;
            this.btnexit.Location = new System.Drawing.Point(1, 1);
            this.btnexit.Name = "btnexit";
            this.btnexit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnexit.ShadowDecoration.Parent = this.btnexit;
            this.btnexit.Size = new System.Drawing.Size(35, 32);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "X";
            this.btnexit.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // btnremove
            // 
            this.btnremove.BorderRadius = 15;
            this.btnremove.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnremove.CheckedState.Parent = this.btnremove;
            this.btnremove.CustomImages.Parent = this.btnremove;
            this.guna2Transition1.SetDecoration(this.btnremove, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnremove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnremove.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.Color.White;
            this.btnremove.HoverState.Parent = this.btnremove;
            this.btnremove.Location = new System.Drawing.Point(-2, 200);
            this.btnremove.Name = "btnremove";
            this.btnremove.ShadowDecoration.Parent = this.btnremove;
            this.btnremove.Size = new System.Drawing.Size(202, 41);
            this.btnremove.TabIndex = 3;
            this.btnremove.Text = "Remove Items";
            // 
            // btnupdate
            // 
            this.btnupdate.BorderRadius = 15;
            this.btnupdate.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnupdate.CheckedState.Parent = this.btnupdate;
            this.btnupdate.CustomImages.Parent = this.btnupdate;
            this.guna2Transition1.SetDecoration(this.btnupdate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnupdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.HoverState.Parent = this.btnupdate;
            this.btnupdate.Location = new System.Drawing.Point(-2, 153);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.ShadowDecoration.Parent = this.btnupdate;
            this.btnupdate.Size = new System.Drawing.Size(202, 41);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Update Items";
            this.btnupdate.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnadditems
            // 
            this.btnadditems.BorderRadius = 15;
            this.btnadditems.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnadditems.CheckedState.Parent = this.btnadditems;
            this.btnadditems.CustomImages.Parent = this.btnadditems;
            this.guna2Transition1.SetDecoration(this.btnadditems, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnadditems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnadditems.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadditems.ForeColor = System.Drawing.Color.White;
            this.btnadditems.HoverState.Parent = this.btnadditems;
            this.btnadditems.Location = new System.Drawing.Point(-2, 106);
            this.btnadditems.Name = "btnadditems";
            this.btnadditems.ShadowDecoration.Parent = this.btnadditems;
            this.btnadditems.Size = new System.Drawing.Size(202, 41);
            this.btnadditems.TabIndex = 1;
            this.btnadditems.Text = "Add Items";
            this.btnadditems.Click += new System.EventHandler(this.btnadditems_Click);
            // 
            // btnplaceorder
            // 
            this.btnplaceorder.BorderRadius = 15;
            this.btnplaceorder.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnplaceorder.CheckedState.Parent = this.btnplaceorder;
            this.btnplaceorder.CustomImages.Parent = this.btnplaceorder;
            this.guna2Transition1.SetDecoration(this.btnplaceorder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnplaceorder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnplaceorder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplaceorder.ForeColor = System.Drawing.Color.White;
            this.btnplaceorder.HoverState.Parent = this.btnplaceorder;
            this.btnplaceorder.Location = new System.Drawing.Point(-2, 59);
            this.btnplaceorder.Name = "btnplaceorder";
            this.btnplaceorder.ShadowDecoration.Parent = this.btnplaceorder;
            this.btnplaceorder.Size = new System.Drawing.Size(202, 41);
            this.btnplaceorder.TabIndex = 0;
            this.btnplaceorder.Text = "Place Order";
            this.btnplaceorder.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.updateitem1);
            this.panel2.Controls.Add(this.placeorderusercontrol1);
            this.panel2.Controls.Add(this.additemusercontrol1);
            this.panel2.Controls.Add(this.userwelcome1);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(209, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 514);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.guna2Transition1.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(362, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(761, 523);
            this.panel3.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // updateitem1
            // 
            this.updateitem1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.updateitem1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.updateitem1.Location = new System.Drawing.Point(0, -3);
            this.updateitem1.Name = "updateitem1";
            this.updateitem1.Size = new System.Drawing.Size(781, 514);
            this.updateitem1.TabIndex = 3;
            // 
            // placeorderusercontrol1
            // 
            this.placeorderusercontrol1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.placeorderusercontrol1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.placeorderusercontrol1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeorderusercontrol1.Location = new System.Drawing.Point(3, 0);
            this.placeorderusercontrol1.Margin = new System.Windows.Forms.Padding(5);
            this.placeorderusercontrol1.Name = "placeorderusercontrol1";
            this.placeorderusercontrol1.Size = new System.Drawing.Size(781, 514);
            this.placeorderusercontrol1.TabIndex = 2;
            // 
            // additemusercontrol1
            // 
            this.guna2Transition1.SetDecoration(this.additemusercontrol1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.additemusercontrol1.Location = new System.Drawing.Point(0, 3);
            this.additemusercontrol1.Name = "additemusercontrol1";
            this.additemusercontrol1.Size = new System.Drawing.Size(781, 514);
            this.additemusercontrol1.TabIndex = 1;
            // 
            // userwelcome1
            // 
            this.guna2Transition1.SetDecoration(this.userwelcome1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userwelcome1.ForeColor = System.Drawing.Color.White;
            this.userwelcome1.Location = new System.Drawing.Point(0, -3);
            this.userwelcome1.Name = "userwelcome1";
            this.userwelcome1.Size = new System.Drawing.Size(781, 514);
            this.userwelcome1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(988, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnremove;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private Guna.UI2.WinForms.Guna2Button btnadditems;
        private Guna.UI2.WinForms.Guna2Button btnplaceorder;
        private Guna.UI2.WinForms.Guna2CircleButton btnexit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.LinkLabel btnlogout;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private allusercontrl.userwelcome userwelcome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private allusercontrl.additemusercontrol additemusercontrol1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private allusercontrl.Placeorderusercontrol placeorderusercontrol1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private allusercontrl.updateitem updateitem1;
    }
}