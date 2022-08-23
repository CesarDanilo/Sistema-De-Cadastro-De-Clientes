namespace Cadastro_de_Clientes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_name_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_sexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_cpf_cnpf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_contato = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.mkx_data_nacimento = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.cbx_ativo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.RichTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbx_cidade = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbx_bairro = new System.Windows.Forms.TextBox();
            this.cbx_uf = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.mkx_cep = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbx_numero = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbx_rua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.idade,
            this.email,
            this.CPF_CNPJ,
            this.contato,
            this.sexo,
            this.data_cadastro,
            this.tipo,
            this.ativo,
            this.cidade,
            this.bairro,
            this.rua,
            this.numero,
            this.uf,
            this.cep,
            this.descricao});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(16, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1874, 393);
            this.dataGridView1.TabIndex = 3;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.FillWeight = 129.6811F;
            this.id.Frozen = true;
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 45;
            this.id.Name = "id";
            this.id.Width = 45;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nome.FillWeight = 101.8114F;
            this.nome.Frozen = true;
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 250;
            this.nome.Name = "nome";
            this.nome.Width = 250;
            // 
            // idade
            // 
            this.idade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idade.FillWeight = 101.8114F;
            this.idade.Frozen = true;
            this.idade.HeaderText = "Idade";
            this.idade.MinimumWidth = 100;
            this.idade.Name = "idade";
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.email.FillWeight = 101.8114F;
            this.email.Frozen = true;
            this.email.HeaderText = "E-mail";
            this.email.MinimumWidth = 200;
            this.email.Name = "email";
            this.email.Width = 200;
            // 
            // CPF_CNPJ
            // 
            this.CPF_CNPJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPF_CNPJ.FillWeight = 101.8114F;
            this.CPF_CNPJ.Frozen = true;
            this.CPF_CNPJ.HeaderText = "CPF/CNPJ";
            this.CPF_CNPJ.MinimumWidth = 130;
            this.CPF_CNPJ.Name = "CPF_CNPJ";
            this.CPF_CNPJ.Width = 130;
            // 
            // contato
            // 
            this.contato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.contato.FillWeight = 101.8114F;
            this.contato.Frozen = true;
            this.contato.HeaderText = "Tel/Cel";
            this.contato.MinimumWidth = 100;
            this.contato.Name = "contato";
            // 
            // sexo
            // 
            this.sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sexo.FillWeight = 101.8114F;
            this.sexo.Frozen = true;
            this.sexo.HeaderText = "Sexo";
            this.sexo.MinimumWidth = 45;
            this.sexo.Name = "sexo";
            this.sexo.Width = 45;
            // 
            // data_cadastro
            // 
            this.data_cadastro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            this.data_cadastro.DefaultCellStyle = dataGridViewCellStyle4;
            this.data_cadastro.FillWeight = 101.8114F;
            this.data_cadastro.Frozen = true;
            this.data_cadastro.HeaderText = "Data de Cadastro";
            this.data_cadastro.MinimumWidth = 130;
            this.data_cadastro.Name = "data_cadastro";
            this.data_cadastro.Width = 130;
            // 
            // tipo
            // 
            this.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tipo.FillWeight = 101.8114F;
            this.tipo.Frozen = true;
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.Width = 78;
            // 
            // ativo
            // 
            this.ativo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ativo.FillWeight = 101.8114F;
            this.ativo.Frozen = true;
            this.ativo.HeaderText = "Ativo";
            this.ativo.Name = "ativo";
            this.ativo.Width = 78;
            // 
            // cidade
            // 
            this.cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cidade.FillWeight = 101.8114F;
            this.cidade.Frozen = true;
            this.cidade.HeaderText = "Cidade";
            this.cidade.MinimumWidth = 120;
            this.cidade.Name = "cidade";
            this.cidade.Width = 120;
            // 
            // bairro
            // 
            this.bairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bairro.FillWeight = 101.8114F;
            this.bairro.Frozen = true;
            this.bairro.HeaderText = "Bairro";
            this.bairro.MinimumWidth = 100;
            this.bairro.Name = "bairro";
            // 
            // rua
            // 
            this.rua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rua.FillWeight = 101.8114F;
            this.rua.Frozen = true;
            this.rua.HeaderText = "Rua";
            this.rua.MinimumWidth = 130;
            this.rua.Name = "rua";
            this.rua.Width = 130;
            // 
            // numero
            // 
            this.numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.numero.FillWeight = 101.8114F;
            this.numero.Frozen = true;
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.Width = 78;
            // 
            // uf
            // 
            this.uf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.uf.FillWeight = 101.8114F;
            this.uf.Frozen = true;
            this.uf.HeaderText = "UF";
            this.uf.MinimumWidth = 30;
            this.uf.Name = "uf";
            this.uf.Width = 30;
            // 
            // cep
            // 
            this.cep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cep.FillWeight = 101.8114F;
            this.cep.Frozen = true;
            this.cep.HeaderText = "CEP";
            this.cep.MinimumWidth = 100;
            this.cep.Name = "cep";
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.FillWeight = 43.1472F;
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 99;
            this.descricao.Name = "descricao";
            // 
            // tbx_id
            // 
            this.tbx_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_id.Location = new System.Drawing.Point(1719, 33);
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.Size = new System.Drawing.Size(52, 26);
            this.tbx_id.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1683, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // tbx_name_search
            // 
            this.tbx_name_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_name_search.Location = new System.Drawing.Point(1210, 33);
            this.tbx_name_search.Name = "tbx_name_search";
            this.tbx_name_search.Size = new System.Drawing.Size(467, 26);
            this.tbx_name_search.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1154, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // tbx_nome
            // 
            this.tbx_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nome.Location = new System.Drawing.Point(126, 533);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(593, 26);
            this.tbx_nome.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(631, 659);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Idade";
            // 
            // cbx_sexo
            // 
            this.cbx_sexo.Font = new System.Drawing.Font("Roboto Mono Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_sexo.FormattingEnabled = true;
            this.cbx_sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbx_sexo.Location = new System.Drawing.Point(832, 533);
            this.cbx_sexo.Name = "cbx_sexo";
            this.cbx_sexo.Size = new System.Drawing.Size(42, 28);
            this.cbx_sexo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 659);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "CPF/CNPJ";
            // 
            // tbx_cpf_cnpf
            // 
            this.tbx_cpf_cnpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_cpf_cnpf.Location = new System.Drawing.Point(166, 654);
            this.tbx_cpf_cnpf.Name = "tbx_cpf_cnpf";
            this.tbx_cpf_cnpf.Size = new System.Drawing.Size(245, 26);
            this.tbx_cpf_cnpf.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 601);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tel/Cel";
            // 
            // tbx_contato
            // 
            this.tbx_contato.Font = new System.Drawing.Font("Roboto Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_contato.Location = new System.Drawing.Point(156, 598);
            this.tbx_contato.Mask = "(99) 00000-0000";
            this.tbx_contato.Name = "tbx_contato";
            this.tbx_contato.Size = new System.Drawing.Size(157, 29);
            this.tbx_contato.TabIndex = 20;
            this.tbx_contato.Tag = "";
            this.tbx_contato.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(334, 601);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "E-Mail";
            // 
            // tbx_email
            // 
            this.tbx_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_email.Location = new System.Drawing.Point(410, 599);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(464, 26);
            this.tbx_email.TabIndex = 22;
            // 
            // mkx_data_nacimento
            // 
            this.mkx_data_nacimento.Font = new System.Drawing.Font("Roboto Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkx_data_nacimento.Location = new System.Drawing.Point(697, 654);
            this.mkx_data_nacimento.Mask = "00-00-0000";
            this.mkx_data_nacimento.Name = "mkx_data_nacimento";
            this.mkx_data_nacimento.Size = new System.Drawing.Size(119, 29);
            this.mkx_data_nacimento.TabIndex = 23;
            this.mkx_data_nacimento.Tag = "";
            this.mkx_data_nacimento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(777, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sexo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(70, 712);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 21);
            this.label10.TabIndex = 25;
            this.label10.Text = "Data de cadastro: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(249, 712);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 21);
            this.label11.TabIndex = 26;
            this.label11.Text = "00-00-0000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(487, 712);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 21);
            this.label12.TabIndex = 27;
            this.label12.Text = "Tipo: ";
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.Font = new System.Drawing.Font("Roboto Mono Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Items.AddRange(new object[] {
            "Física ",
            "Jurídica "});
            this.cbx_tipo.Location = new System.Drawing.Point(563, 710);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(101, 28);
            this.cbx_tipo.TabIndex = 28;
            // 
            // cbx_ativo
            // 
            this.cbx_ativo.Font = new System.Drawing.Font("Roboto Mono Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ativo.FormattingEnabled = true;
            this.cbx_ativo.Items.AddRange(new object[] {
            "Ativo",
            "Não ativo"});
            this.cbx_ativo.Location = new System.Drawing.Point(804, 710);
            this.cbx_ativo.Name = "cbx_ativo";
            this.cbx_ativo.Size = new System.Drawing.Size(70, 28);
            this.cbx_ativo.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(728, 712);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 21);
            this.label13.TabIndex = 29;
            this.label13.Text = "Ativo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(69, 487);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 28);
            this.label14.TabIndex = 31;
            this.label14.Text = "Cliente: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Roboto Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Location = new System.Drawing.Point(1079, 630);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(142, 28);
            this.label21.TabIndex = 46;
            this.label21.Text = "Descrição:";
            // 
            // txt_descricao
            // 
            this.txt_descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_descricao.Font = new System.Drawing.Font("Roboto Mono Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao.Location = new System.Drawing.Point(1083, 661);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(743, 238);
            this.txt_descricao.TabIndex = 47;
            this.txt_descricao.Text = "";
            this.txt_descricao.TextChanged += new System.EventHandler(this.cbx_tipo_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1548, 531);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 21);
            this.label20.TabIndex = 61;
            this.label20.Text = "Cidade:";
            // 
            // tbx_cidade
            // 
            this.tbx_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_cidade.Location = new System.Drawing.Point(1634, 531);
            this.tbx_cidade.Name = "tbx_cidade";
            this.tbx_cidade.Size = new System.Drawing.Size(192, 26);
            this.tbx_cidade.TabIndex = 60;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1508, 578);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 21);
            this.label19.TabIndex = 59;
            this.label19.Text = "Bairro:";
            // 
            // tbx_bairro
            // 
            this.tbx_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_bairro.Location = new System.Drawing.Point(1594, 578);
            this.tbx_bairro.Name = "tbx_bairro";
            this.tbx_bairro.Size = new System.Drawing.Size(232, 26);
            this.tbx_bairro.TabIndex = 58;
            // 
            // cbx_uf
            // 
            this.cbx_uf.Font = new System.Drawing.Font("Roboto Mono Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_uf.FormattingEnabled = true;
            this.cbx_uf.Items.AddRange(new object[] {
            "RO",
            "AC",
            "AM",
            "RR",
            "PA",
            "AP",
            "TO",
            "MA",
            "PI",
            "CE",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "BA",
            "MG",
            "ES",
            "RJ",
            "SP",
            "PR",
            "SC",
            "RS",
            "MS",
            "MT",
            "GO",
            "DF"});
            this.cbx_uf.Location = new System.Drawing.Point(1399, 576);
            this.cbx_uf.Name = "cbx_uf";
            this.cbx_uf.Size = new System.Drawing.Size(61, 28);
            this.cbx_uf.TabIndex = 57;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1306, 578);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 21);
            this.label17.TabIndex = 56;
            this.label17.Text = "UF:";
            // 
            // mkx_cep
            // 
            this.mkx_cep.Font = new System.Drawing.Font("Roboto Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkx_cep.Location = new System.Drawing.Point(1135, 575);
            this.mkx_cep.Mask = "00000-000";
            this.mkx_cep.Name = "mkx_cep";
            this.mkx_cep.Size = new System.Drawing.Size(98, 29);
            this.mkx_cep.TabIndex = 55;
            this.mkx_cep.Tag = "";
            this.mkx_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1079, 578);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 21);
            this.label18.TabIndex = 54;
            this.label18.Text = "CEP:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1420, 531);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 21);
            this.label16.TabIndex = 53;
            this.label16.Text = "N°:";
            // 
            // tbx_numero
            // 
            this.tbx_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_numero.Location = new System.Drawing.Point(1466, 529);
            this.tbx_numero.Name = "tbx_numero";
            this.tbx_numero.Size = new System.Drawing.Size(76, 26);
            this.tbx_numero.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1080, 531);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 21);
            this.label15.TabIndex = 51;
            this.label15.Text = "Rua:";
            // 
            // tbx_rua
            // 
            this.tbx_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_rua.Location = new System.Drawing.Point(1136, 529);
            this.tbx_rua.Name = "tbx_rua";
            this.tbx_rua.Size = new System.Drawing.Size(277, 26);
            this.tbx_rua.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(1079, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 28);
            this.label7.TabIndex = 49;
            this.label7.Text = "Endereço: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto Mono Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Cadastro_de_Clientes.Properties.Resources.reload_update_refresh_icon_143703;
            this.button1.Location = new System.Drawing.Point(1845, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 43);
            this.button1.TabIndex = 48;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Image = global::Cadastro_de_Clientes.Properties.Resources.lupa;
            this.btn_search.Location = new System.Drawing.Point(1794, 23);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(45, 43);
            this.btn_search.TabIndex = 4;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Roboto Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = global::Cadastro_de_Clientes.Properties.Resources.delete;
            this.btn_delete.Location = new System.Drawing.Point(256, 814);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(85, 85);
            this.btn_delete.TabIndex = 67;
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Roboto Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Image = global::Cadastro_de_Clientes.Properties.Resources.editdocument;
            this.btn_update.Location = new System.Drawing.Point(165, 814);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(85, 85);
            this.btn_update.TabIndex = 66;
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Roboto Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::Cadastro_de_Clientes.Properties.Resources.save;
            this.btn_save.Location = new System.Drawing.Point(74, 814);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(85, 85);
            this.btn_save.TabIndex = 65;
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1902, 911);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tbx_cidade);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbx_bairro);
            this.Controls.Add(this.cbx_uf);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.mkx_cep);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbx_numero);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbx_rua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbx_ativo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbx_tipo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mkx_data_nacimento);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbx_contato);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbx_cpf_cnpf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_sexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_name_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_id);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 950);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_name_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_sexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_cpf_cnpf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox tbx_contato;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.MaskedTextBox mkx_data_nacimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.ComboBox cbx_ativo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RichTextBox txt_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_cadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbx_cidade;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbx_bairro;
        private System.Windows.Forms.ComboBox cbx_uf;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox mkx_cep;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbx_numero;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbx_rua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
    }
}

