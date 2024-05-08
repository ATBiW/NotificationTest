namespace FinalNotificationApp
{
    partial class ToastForms
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
            this.toastBorder = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.toastTimer = new System.Windows.Forms.Timer(this.components);
            this.toastHide = new System.Windows.Forms.Timer(this.components);
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // toastBorder
            // 
            this.toastBorder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toastBorder.Location = new System.Drawing.Point(0, -1);
            this.toastBorder.Name = "toastBorder";
            this.toastBorder.Size = new System.Drawing.Size(18, 63);
            this.toastBorder.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(88, 8);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 16);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(88, 32);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(64, 16);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Message";
            // 
            // toastTimer
            // 
            this.toastTimer.Enabled = true;
            this.toastTimer.Interval = 10;
            this.toastTimer.Tick += new System.EventHandler(this.toastTimer_Tick);
            // 
            // toastHide
            // 
            this.toastHide.Interval = 10;
            this.toastHide.Tick += new System.EventHandler(this.toastHide_Tick);
            // 
            // picIcon
            // 
            this.picIcon.BackgroundImage = global::FinalNotificationApp.Properties.Resources.information_button;
            this.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIcon.Image = global::FinalNotificationApp.Properties.Resources.information_button;
            this.picIcon.Location = new System.Drawing.Point(24, 8);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(40, 40);
            this.picIcon.TabIndex = 1;
            this.picIcon.TabStop = false;
            // 
            // ToastForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 60);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.toastBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToastForms";
            this.Text = "ToastForms";
            this.Load += new System.EventHandler(this.ToastForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toastBorder;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer toastTimer;
        private System.Windows.Forms.Timer toastHide;
    }
}