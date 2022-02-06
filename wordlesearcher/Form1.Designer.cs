namespace wordlesearcher
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_letter1 = new System.Windows.Forms.TextBox();
            this.btn_NoUse = new System.Windows.Forms.Button();
            this.btn_Molu = new System.Windows.Forms.Button();
            this.lb_NoUse = new System.Windows.Forms.ListBox();
            this.lb_letterMolu = new System.Windows.Forms.ListBox();
            this.lb_filter = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_letter_order_1 = new System.Windows.Forms.TextBox();
            this.tb_letter_order_2 = new System.Windows.Forms.TextBox();
            this.tb_letter_order_3 = new System.Windows.Forms.TextBox();
            this.tb_letter_order_4 = new System.Windows.Forms.TextBox();
            this.tb_letter_order_5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_bf = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_bf = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.btn_clearNouse = new System.Windows.Forms.Button();
            this.btn_clearMolu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_letter1
            // 
            this.tb_letter1.Location = new System.Drawing.Point(13, 15);
            this.tb_letter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_letter1.Name = "tb_letter1";
            this.tb_letter1.Size = new System.Drawing.Size(61, 29);
            this.tb_letter1.TabIndex = 0;
            // 
            // btn_NoUse
            // 
            this.btn_NoUse.Location = new System.Drawing.Point(82, 14);
            this.btn_NoUse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_NoUse.Name = "btn_NoUse";
            this.btn_NoUse.Size = new System.Drawing.Size(128, 30);
            this.btn_NoUse.TabIndex = 1;
            this.btn_NoUse.Text = "안씀";
            this.btn_NoUse.UseVisualStyleBackColor = true;
            this.btn_NoUse.Click += new System.EventHandler(this.btn_NoUse_Click);
            // 
            // btn_Molu
            // 
            this.btn_Molu.Location = new System.Drawing.Point(218, 15);
            this.btn_Molu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Molu.Name = "btn_Molu";
            this.btn_Molu.Size = new System.Drawing.Size(128, 30);
            this.btn_Molu.TabIndex = 2;
            this.btn_Molu.Text = "순서몰?루";
            this.btn_Molu.UseVisualStyleBackColor = true;
            this.btn_Molu.Click += new System.EventHandler(this.btn_Molu_Click);
            // 
            // lb_NoUse
            // 
            this.lb_NoUse.FormattingEnabled = true;
            this.lb_NoUse.ItemHeight = 21;
            this.lb_NoUse.Location = new System.Drawing.Point(82, 52);
            this.lb_NoUse.Name = "lb_NoUse";
            this.lb_NoUse.Size = new System.Drawing.Size(128, 172);
            this.lb_NoUse.TabIndex = 6;
            // 
            // lb_letterMolu
            // 
            this.lb_letterMolu.FormattingEnabled = true;
            this.lb_letterMolu.ItemHeight = 21;
            this.lb_letterMolu.Location = new System.Drawing.Point(218, 53);
            this.lb_letterMolu.Name = "lb_letterMolu";
            this.lb_letterMolu.Size = new System.Drawing.Size(128, 172);
            this.lb_letterMolu.TabIndex = 7;
            // 
            // lb_filter
            // 
            this.lb_filter.FormattingEnabled = true;
            this.lb_filter.ItemHeight = 21;
            this.lb_filter.Location = new System.Drawing.Point(487, 287);
            this.lb_filter.Name = "lb_filter";
            this.lb_filter.Size = new System.Drawing.Size(128, 172);
            this.lb_filter.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "글자 입력";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "무작위 단어 목록";
            // 
            // tb_letter_order_1
            // 
            this.tb_letter_order_1.Location = new System.Drawing.Point(352, 53);
            this.tb_letter_order_1.Name = "tb_letter_order_1";
            this.tb_letter_order_1.Size = new System.Drawing.Size(39, 29);
            this.tb_letter_order_1.TabIndex = 12;
            // 
            // tb_letter_order_2
            // 
            this.tb_letter_order_2.Location = new System.Drawing.Point(397, 53);
            this.tb_letter_order_2.Name = "tb_letter_order_2";
            this.tb_letter_order_2.Size = new System.Drawing.Size(39, 29);
            this.tb_letter_order_2.TabIndex = 13;
            // 
            // tb_letter_order_3
            // 
            this.tb_letter_order_3.Location = new System.Drawing.Point(442, 53);
            this.tb_letter_order_3.Name = "tb_letter_order_3";
            this.tb_letter_order_3.Size = new System.Drawing.Size(39, 29);
            this.tb_letter_order_3.TabIndex = 14;
            // 
            // tb_letter_order_4
            // 
            this.tb_letter_order_4.Location = new System.Drawing.Point(487, 53);
            this.tb_letter_order_4.Name = "tb_letter_order_4";
            this.tb_letter_order_4.Size = new System.Drawing.Size(39, 29);
            this.tb_letter_order_4.TabIndex = 15;
            // 
            // tb_letter_order_5
            // 
            this.tb_letter_order_5.Location = new System.Drawing.Point(532, 53);
            this.tb_letter_order_5.Name = "tb_letter_order_5";
            this.tb_letter_order_5.Size = new System.Drawing.Size(39, 29);
            this.tb_letter_order_5.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "순서 아!루";
            // 
            // lb_bf
            // 
            this.lb_bf.FormattingEnabled = true;
            this.lb_bf.ItemHeight = 21;
            this.lb_bf.Location = new System.Drawing.Point(355, 287);
            this.lb_bf.Name = "lb_bf";
            this.lb_bf.Size = new System.Drawing.Size(126, 172);
            this.lb_bf.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "단어사전 필터링";
            // 
            // btn_bf
            // 
            this.btn_bf.Location = new System.Drawing.Point(218, 287);
            this.btn_bf.Name = "btn_bf";
            this.btn_bf.Size = new System.Drawing.Size(128, 61);
            this.btn_bf.TabIndex = 20;
            this.btn_bf.Text = "후보군 생성";
            this.btn_bf.UseVisualStyleBackColor = true;
            this.btn_bf.Click += new System.EventHandler(this.btn_bf_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(218, 354);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(128, 61);
            this.btn_filter.TabIndex = 21;
            this.btn_filter.Text = "사전 필터링";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(594, 20);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.ReadOnly = true;
            this.tb_log.Size = new System.Drawing.Size(174, 133);
            this.tb_log.TabIndex = 22;
            // 
            // btn_clearNouse
            // 
            this.btn_clearNouse.Location = new System.Drawing.Point(82, 232);
            this.btn_clearNouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_clearNouse.Name = "btn_clearNouse";
            this.btn_clearNouse.Size = new System.Drawing.Size(128, 30);
            this.btn_clearNouse.TabIndex = 23;
            this.btn_clearNouse.Text = "초기화";
            this.btn_clearNouse.UseVisualStyleBackColor = true;
            this.btn_clearNouse.Click += new System.EventHandler(this.btn_clearNouse_Click);
            // 
            // btn_clearMolu
            // 
            this.btn_clearMolu.Location = new System.Drawing.Point(218, 231);
            this.btn_clearMolu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_clearMolu.Name = "btn_clearMolu";
            this.btn_clearMolu.Size = new System.Drawing.Size(128, 30);
            this.btn_clearMolu.TabIndex = 24;
            this.btn_clearMolu.Text = "초기화";
            this.btn_clearMolu.UseVisualStyleBackColor = true;
            this.btn_clearMolu.Click += new System.EventHandler(this.btn_clearMolu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 493);
            this.Controls.Add(this.btn_clearMolu);
            this.Controls.Add(this.btn_clearNouse);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.btn_bf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_bf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_letter_order_5);
            this.Controls.Add(this.tb_letter_order_4);
            this.Controls.Add(this.tb_letter_order_3);
            this.Controls.Add(this.tb_letter_order_2);
            this.Controls.Add(this.tb_letter_order_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_filter);
            this.Controls.Add(this.lb_letterMolu);
            this.Controls.Add(this.lb_NoUse);
            this.Controls.Add(this.btn_Molu);
            this.Controls.Add(this.btn_NoUse);
            this.Controls.Add(this.tb_letter1);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_letter1;
        private System.Windows.Forms.Button btn_NoUse;
        private System.Windows.Forms.Button btn_Molu;
        private System.Windows.Forms.ListBox lb_NoUse;
        private System.Windows.Forms.ListBox lb_letterMolu;
        private System.Windows.Forms.ListBox lb_filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_letter_order_1;
        private System.Windows.Forms.TextBox tb_letter_order_2;
        private System.Windows.Forms.TextBox tb_letter_order_3;
        private System.Windows.Forms.TextBox tb_letter_order_4;
        private System.Windows.Forms.TextBox tb_letter_order_5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_bf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_bf;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.Button btn_clearNouse;
        private System.Windows.Forms.Button btn_clearMolu;
    }
}

