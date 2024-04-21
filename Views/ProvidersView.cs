﻿using Azure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class ProvidersView : Form, IProvidersView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string Message;

        public ProvidersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageProvidersDetail);

            BtnProviderClose.Click += delegate { this.Close(); };

        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnProviderSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtProviderSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            BtnProviderNew.Click += delegate {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProvidersList);
                tabControl1.TabPages.Add(tabPageProvidersDetail);
                tabPageProvidersDetail.Text = "Add New Provider";

            };
            BtnProviderEdit.Click += delegate {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProvidersList);
                tabControl1.TabPages.Add(tabPageProvidersDetail);
                tabPageProvidersDetail.Text = "Edit Provider";

            };

            BtnProviderDelete.Click += delegate {
                DeleteEvent?.Invoke(this, EventArgs.Empty);

                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Provider",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }

            };

            BtnSave.Click += delegate {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageProvidersDetail);
                    tabControl1.TabPages.Add(tabPageProvidersList);
                }
                MessageBox.Show(Message);

            };

            BtnCancel.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProvidersDetail);
                tabControl1.TabPages.Add(tabPageProvidersList);
            };

        }

        public string ProviderId
        {
            get { return TxtId.Text; }
            set { TxtId.Text = value; }

        }
        public string ProviderName
        {
            get { return TxtName.Text; }
            set { TxtName.Text = value; }

        }
        public string ProviderObservation
        {
            get { return TxtObservation.Text; }
            set { TxtObservation.Text = value; }

        }
        public string SearchValue
        {
            get { return TxtProviderSearch.Text; }
            set { TxtProviderSearch.Text = value; }

        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccesful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }

        }
        public string Menssage
        {
            get { return Message; }
            set { Message = value; }

        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProvidersListBildingSource(BindingSource providersList)
        {
            DgProviders.DataSource = providersList;
        }
        private static ProvidersView instance;

        public static ProvidersView GetInstance(Form parenContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProvidersView();
                instance.MdiParent = parenContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();


            }
            return instance;
        }




            private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
