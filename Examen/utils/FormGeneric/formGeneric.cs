using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

using Examen.Context;
using project.utils.interfaces;
using FluentValidation;
using AutoMapper;
using System.Data.Entity;

namespace Examen.utils.FormGeneric
{
    public  class formGeneric<t> 
        where t : class
    {
        private DataGridView dataGriwList;
        private Button btn_save;
        private Button btn_delete;
        private Button btn_clean;
        private ExamenContext db;
        public  t currentRegister { get; set; }
        private IMapper mapper;
        
        public Action clearForm { get; set; }
        public Action<t> setData { get; set; }
        public Action saveData { get; set; }

        public formGeneric(ExamenContext context,IMapper mapperTemp)
        {
            db = context;
            mapper = mapperTemp;
        }

        public void load(MaterialForm form)
        {
            dataGriwList = new DataGridView();
            btn_save = new Button();
            btn_delete = new Button();
            btn_clean = new Button();
            // dataGriwList
            dataGriwList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGriwList.Location = new Point(397, 95);
            dataGriwList.Name = "dataGriwList";
            dataGriwList.ReadOnly = true;
            dataGriwList.RowHeadersWidth = 51;
            dataGriwList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGriwList.Size = new Size(562, 417);
            dataGriwList.TabIndex = 0;
            dataGriwList.Click += dataGriwList_Click;
             
            
            // btn_save
            btn_save.Location = new Point(42, 282);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(257, 29);
            btn_save.TabIndex = 6;
            btn_save.Text = "Guardar";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // btn_delete
            btn_delete.BackColor = Color.FromArgb(255, 128, 128);
            btn_delete.Location = new Point(42, 353);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(257, 29);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Eliminar";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // btn_clean
            btn_clean.BackColor = SystemColors.ActiveCaption;
            btn_clean.Location = new Point(42, 318);
            btn_clean.Name = "btn_clean";
            btn_clean.Size = new Size(257, 29);
            btn_clean.TabIndex = 8;
            btn_clean.Text = "Limpiar";
            btn_clean.UseVisualStyleBackColor = false;
            btn_clean.Click += btn_clean_Click;
            // brandsView
            form.Controls.Add(btn_clean);
            form.Controls.Add(btn_delete);
            form.Controls.Add(btn_save);
            form.Controls.Add(dataGriwList);
            ((System.ComponentModel.ISupportInitialize)dataGriwList).EndInit();
        }


        

        public void loadList()
        {
            dataGriwList.DataSource = db.Set<t>().Where(x =>  ((ICommonModel<long>) x).deleteAt == null).ToList();
        }


        public async Task save(t current)
        {
            if (current == null) return;
            if (currentRegister != null)
            {
                t registerTemp = db.Set<t>().FirstOrDefault
                    (x => 
                        ((ICommonModel<long>)x).Id.Equals(((ICommonModel<long>)currentRegister).Id) && ((ICommonModel<long>)x).deleteAt == null);
                if (registerTemp == null)
                {
                    MessageBox.Show("Registro no encontrado");
                    return;
                }
                registerTemp=mapper.Map(current, registerTemp);

            }
            else
            {
                db.Set<t>().Add(current);
            }

            db.SaveChanges();

            MessageBox.Show("Registro guardado");
            loadList();
            clearForm();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveData();
        }


        private void btn_clean_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (currentRegister == null)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            t registerDelete =  db.Set<t>().FirstOrDefault(x => ((ICommonModel<long>)x).Id.Equals(((ICommonModel<long>)currentRegister).Id) && ((ICommonModel<long>)x).deleteAt == null);
            if (registerDelete == null)
            {
                MessageBox.Show("Registro no encontrado");
                return;
            }
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este registro?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                ((ICommonModel<long>)registerDelete).deleteAt = DateTime.UtcNow;
                await db.SaveChangesAsync();
                loadList();
                MessageBox.Show("El registro ha sido eliminado.");
            }
            clearForm();
        }

        private void dataGriwList_Click(object sender, EventArgs e)
        {
            if (dataGriwList.SelectedRows.Count > 0)
            {
                int selectedRow = dataGriwList.SelectedRows[0].Index;
                currentRegister = (t)dataGriwList.Rows[selectedRow].DataBoundItem;
                setData(currentRegister);
            }
        }
    }
    }

