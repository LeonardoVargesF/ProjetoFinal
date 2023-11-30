namespace GerEventos.App.Cadastros
{
    partial class CadastroInscricao
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
            this.cboParticipante = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboEvento = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtDataInscricao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(563, 206);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.txtId);
            this.tabPageCadastro.Controls.Add(this.txtDataInscricao);
            this.tabPageCadastro.Controls.Add(this.cboEvento);
            this.tabPageCadastro.Controls.Add(this.cboParticipante);
            this.tabPageCadastro.Size = new System.Drawing.Size(555, 171);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboParticipante, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboEvento, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtDataInscricao, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtId, 0);
            // 
            // cboParticipante
            // 
            this.cboParticipante.AutoResize = false;
            this.cboParticipante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboParticipante.Depth = 0;
            this.cboParticipante.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboParticipante.DropDownHeight = 174;
            this.cboParticipante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParticipante.DropDownWidth = 121;
            this.cboParticipante.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboParticipante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboParticipante.FormattingEnabled = true;
            this.cboParticipante.Hint = "Participante";
            this.cboParticipante.IntegralHeight = false;
            this.cboParticipante.ItemHeight = 43;
            this.cboParticipante.Location = new System.Drawing.Point(7, 6);
            this.cboParticipante.MaxDropDownItems = 4;
            this.cboParticipante.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboParticipante.Name = "cboParticipante";
            this.cboParticipante.Size = new System.Drawing.Size(409, 49);
            this.cboParticipante.StartIndex = 0;
            this.cboParticipante.TabIndex = 2;
            // 
            // cboEvento
            // 
            this.cboEvento.AutoResize = false;
            this.cboEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboEvento.Depth = 0;
            this.cboEvento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboEvento.DropDownHeight = 174;
            this.cboEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvento.DropDownWidth = 121;
            this.cboEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboEvento.FormattingEnabled = true;
            this.cboEvento.Hint = "Evento";
            this.cboEvento.IntegralHeight = false;
            this.cboEvento.ItemHeight = 43;
            this.cboEvento.Location = new System.Drawing.Point(7, 61);
            this.cboEvento.MaxDropDownItems = 4;
            this.cboEvento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboEvento.Name = "cboEvento";
            this.cboEvento.Size = new System.Drawing.Size(409, 49);
            this.cboEvento.StartIndex = 0;
            this.cboEvento.TabIndex = 3;
            // 
            // txtDataInscricao
            // 
            this.txtDataInscricao.AllowPromptAsInput = true;
            this.txtDataInscricao.AnimateReadOnly = false;
            this.txtDataInscricao.AsciiOnly = false;
            this.txtDataInscricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDataInscricao.BeepOnError = false;
            this.txtDataInscricao.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDataInscricao.Depth = 0;
            this.txtDataInscricao.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataInscricao.HidePromptOnLeave = false;
            this.txtDataInscricao.HideSelection = true;
            this.txtDataInscricao.Hint = "Data da Inscrição";
            this.txtDataInscricao.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtDataInscricao.LeadingIcon = null;
            this.txtDataInscricao.Location = new System.Drawing.Point(422, 62);
            this.txtDataInscricao.Mask = "99/99/9999";
            this.txtDataInscricao.MaxLength = 32767;
            this.txtDataInscricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDataInscricao.Name = "txtDataInscricao";
            this.txtDataInscricao.PasswordChar = '\0';
            this.txtDataInscricao.PrefixSuffixText = null;
            this.txtDataInscricao.PromptChar = '_';
            this.txtDataInscricao.ReadOnly = false;
            this.txtDataInscricao.RejectInputOnFirstFailure = false;
            this.txtDataInscricao.ResetOnPrompt = true;
            this.txtDataInscricao.ResetOnSpace = true;
            this.txtDataInscricao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDataInscricao.SelectedText = "";
            this.txtDataInscricao.SelectionLength = 0;
            this.txtDataInscricao.SelectionStart = 0;
            this.txtDataInscricao.ShortcutsEnabled = true;
            this.txtDataInscricao.Size = new System.Drawing.Size(124, 48);
            this.txtDataInscricao.SkipLiterals = true;
            this.txtDataInscricao.TabIndex = 4;
            this.txtDataInscricao.TabStop = false;
            this.txtDataInscricao.Text = "  /  /";
            this.txtDataInscricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDataInscricao.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDataInscricao.TrailingIcon = null;
            this.txtDataInscricao.UseSystemPasswordChar = false;
            this.txtDataInscricao.ValidatingType = null;
            // 
            // txtId
            // 
            this.txtId.AnimateReadOnly = false;
            this.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtId.Depth = 0;
            this.txtId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.HideSelection = true;
            this.txtId.Hint = "Id";
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(422, 8);
            this.txtId.MaxLength = 32767;
            this.txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PrefixSuffixText = null;
            this.txtId.ReadOnly = true;
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(124, 48);
            this.txtId.TabIndex = 5;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // CadastroInscricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 273);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroInscricao";
            this.Text = "Inscrição de Participante";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataInscricao;
        private ReaLTaiizor.Controls.MaterialComboBox cboEvento;
        private ReaLTaiizor.Controls.MaterialComboBox cboParticipante;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}