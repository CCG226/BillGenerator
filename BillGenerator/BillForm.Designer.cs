using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BillGenerator
{


    partial class BillForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            panel = new Panel();
            panelLabel = new Label();
            billLabel = new Label();
            taxLabel = new Label();
            tipLabel = new Label();
            billBox = new TextBox();
            taxBox = new TextBox();
            tipBox = new TextBox();
            totalOutput = new Label();
            errMsg = new Label();
            calculateBtn = new Button();
            clearBtn = new Button();
            thanksMsg = new Label();
            themeBtn = new Button();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(210, 11);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(680, 149);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Restaurant Bill Generator";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top;
            panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(panelLabel);
            panel.Controls.Add(billLabel);
            panel.Controls.Add(taxLabel);
            panel.Controls.Add(tipLabel);
            panel.Controls.Add(billBox);
            panel.Controls.Add(taxBox);
            panel.Controls.Add(tipBox);
            panel.Controls.Add(totalOutput);
            panel.Controls.Add(errMsg);
            panel.Controls.Add(calculateBtn);
            panel.Controls.Add(clearBtn);
            panel.Location = new Point(243, 226);
            panel.Name = "panel";
            panel.Size = new Size(613, 590);
            panel.TabIndex = 1;
            // 
            // panelLabel
            // 
            panelLabel.Dock = DockStyle.Top;
            panelLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            panelLabel.Location = new Point(0, 0);
            panelLabel.Name = "panelLabel";
            panelLabel.Size = new Size(611, 100);
            panelLabel.TabIndex = 0;
            panelLabel.Text = "Details";
            panelLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // billLabel
            // 
            billLabel.Anchor = AnchorStyles.Left;
            billLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            billLabel.Location = new Point(81, 123);
            billLabel.Name = "billLabel";
            billLabel.Size = new Size(162, 67);
            billLabel.TabIndex = 1;
            billLabel.Text = "Bill $: ";
            billLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // taxLabel
            // 
            taxLabel.Anchor = AnchorStyles.Left;
            taxLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            taxLabel.Location = new Point(81, 181);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(162, 67);
            taxLabel.TabIndex = 1;
            taxLabel.Text = "Sales Tax %: ";
            taxLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tipLabel
            // 
            tipLabel.Anchor = AnchorStyles.Left;
            tipLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tipLabel.Location = new Point(81, 248);
            tipLabel.Name = "tipLabel";
            tipLabel.Size = new Size(162, 67);
            tipLabel.TabIndex = 1;
            tipLabel.Text = "Tip %: ";
            tipLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // billBox
            // 
            billBox.Anchor = AnchorStyles.Right;
            billBox.Location = new Point(364, 148);
            billBox.Margin = new Padding(3, 4, 3, 4);
            billBox.Name = "billBox";
            billBox.Size = new Size(131, 27);
            billBox.TabIndex = 0;
            // 
            // taxBox
            // 
            taxBox.Anchor = AnchorStyles.Right;
            taxBox.Location = new Point(364, 206);
            taxBox.Margin = new Padding(3, 4, 3, 4);
            taxBox.Name = "taxBox";
            taxBox.Size = new Size(131, 27);
            taxBox.TabIndex = 0;
            // 
            // tipBox
            // 
            tipBox.Anchor = AnchorStyles.Right;
            tipBox.Location = new Point(364, 273);
            tipBox.Margin = new Padding(3, 4, 3, 4);
            tipBox.Name = "tipBox";
            tipBox.Size = new Size(131, 27);
            tipBox.TabIndex = 0;
            // 
            // totalOutput
            // 
            totalOutput.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            totalOutput.Location = new Point(0, 437);
            totalOutput.Name = "totalOutput";
            totalOutput.Size = new Size(611, 57);
            totalOutput.TabIndex = 0;
            totalOutput.Text = "Total: ";
            totalOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errMsg
            // 
            errMsg.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            errMsg.ForeColor = Color.Red;
            errMsg.Location = new Point(3, 320);
            errMsg.Name = "errMsg";
            errMsg.Size = new Size(608, 129);
            errMsg.TabIndex = 0;
            errMsg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calculateBtn
            // 
            calculateBtn.BackColor = Color.RoyalBlue;
            calculateBtn.FlatAppearance.BorderSize = 0;
            calculateBtn.FlatStyle = FlatStyle.Flat;
            calculateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            calculateBtn.Location = new Point(94, 497);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(133, 44);
            calculateBtn.TabIndex = 0;
            calculateBtn.Text = "Calculate";
            calculateBtn.UseVisualStyleBackColor = false;
            calculateBtn.Click += Calculate_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.RoyalBlue;
            clearBtn.FlatAppearance.BorderSize = 0;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.Location = new Point(362, 498);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(133, 44);
            clearBtn.TabIndex = 0;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += Clear_Click;
            // 
            // thanksMsg
            // 
            thanksMsg.AutoSize = true;
            thanksMsg.Font = new Font("Segoe UI", 17F, FontStyle.Italic, GraphicsUnit.Point);
            thanksMsg.Location = new Point(433, 173);
            thanksMsg.Name = "thanksMsg";
            thanksMsg.Size = new Size(0, 40);
            thanksMsg.TabIndex = 2;
            thanksMsg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // themeBtn
            // 
            themeBtn.BackColor = Color.White;
            themeBtn.FlatAppearance.BorderSize = 2;
            themeBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            themeBtn.ForeColor = Color.Black;
            themeBtn.Location = new Point(65, 148);
            themeBtn.Name = "themeBtn";
            themeBtn.Size = new Size(121, 43);
            themeBtn.TabIndex = 3;
            themeBtn.Text = "LightMode";
            themeBtn.UseVisualStyleBackColor = false;
            themeBtn.Click += Theme_Click;
            // 
            // BillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 863);
            Controls.Add(themeBtn);
            Controls.Add(thanksMsg);
            Controls.Add(titleLabel);
            Controls.Add(panel);
            Name = "BillForm";
            Text = "Bill Generator";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private Label titleLabel;
        private Panel panel;
        private Label panelLabel;
        private Label billLabel;
        private Label taxLabel;
        private Label tipLabel;
        private TextBox billBox;
        private TextBox taxBox;
        private TextBox tipBox;
        private Button calculateBtn;
        private Button clearBtn;
        private Label totalOutput;
        private Label errMsg;
        private Label thanksMsg;
        private Button themeBtn;
    }
}