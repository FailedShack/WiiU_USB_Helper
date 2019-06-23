using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x020001AD RID: 429
	public partial class frmSupport : RadForm
	{
		// Token: 0x06000BDD RID: 3037 RVA: 0x00018642 File Offset: 0x00016842
		public frmSupport()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0001865B File Offset: 0x0001685B
		public frmSupport(string string_1) : this()
		{
			this.string_0 = string_1;
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x0001564E File Offset: 0x0001384E
		private void method_0(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00047A7C File Offset: 0x00045C7C
		private void frmSupport_Load(object sender, EventArgs e)
		{
			DateTime dateTime = new DateTime(2017, 10, 10, 12, 0, 0).ToLocalTime();
			DateTime dateTime2 = new DateTime(2017, 10, 10, 17, 0, 0).ToLocalTime();
			this.lblusualtime.Text = string.Format("<html><p>Usually, assistance is provided between <span style=\"color: #ff8000\">{0}</span> and <span style=\"color: #ff8000\">{1}</span>.</p></html>", dateTime.ToShortTimeString(), dateTime2.ToShortTimeString());
			this.timeViewer.MinDate = DateTime.Now.AddDays(1.0);
			this.timeViewer.DateTimePickerElement.ShowTimePicker = true;
			this.timeViewer.Format = DateTimePickerFormat.Custom;
			this.timeViewer.CustomFormat = CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern;
			(this.timeViewer.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).DropDownMinSize = new Size(400, 375);
			this.lstTitles.BeginUpdate();
			foreach (GClass32 gclass in GClass28.dictionary_0.Values)
			{
				this.lstTitles.Items.Add(new ListViewDataItem(gclass)
				{
					Tag = gclass
				});
				foreach (GClass33 gclass2 in gclass.Updates)
				{
					this.lstTitles.Items.Add(new ListViewDataItem(gclass2)
					{
						Tag = gclass2
					});
				}
				if (gclass.Boolean_2)
				{
					this.lstTitles.Items.Add(new ListViewDataItem(gclass.Dlc)
					{
						Tag = gclass.Dlc
					});
				}
			}
			this.lstTitles.EndUpdate();
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00047C74 File Offset: 0x00045E74
		private bool method_1(string string_1)
		{
			bool result;
			try
			{
				result = (new MailAddress(string_1).Address == string_1);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0001866A File Offset: 0x0001686A
		private void radButton1_Click(object sender, EventArgs e)
		{
			new frmFaq().ShowDialog();
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00018677 File Offset: 0x00016877
		private void radButton2_Click(object sender, EventArgs e)
		{
			this.radPageView1.SelectedPage = this.radPageView1.Pages[1];
			this.txtEmail.Focus();
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00047CAC File Offset: 0x00045EAC
		private void radButton3_Click(object sender, EventArgs e)
		{
			if (!this.method_1(this.txtEmail.Text))
			{
				RadMessageBox.Show("You must specify a valid email address, otherwise we can't reply to you!");
				return;
			}
			this.radPageView1.SelectedPage = this.radPageView1.Pages[2];
			this.txtTitle.Focus();
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00047D00 File Offset: 0x00045F00
		private void radButton4_Click(object sender, EventArgs e)
		{
			if (this.txtTitle.Text == "")
			{
				RadMessageBox.Show("Please provide a short description of the issue.");
				return;
			}
			this.radPageView1.SelectedPage = this.radPageView1.Pages[3];
			this.txtRemarks.Focus();
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00047D58 File Offset: 0x00045F58
		private void radButton5_Click(object sender, EventArgs e)
		{
			if (this.txtRemarks.Text.Length < 40)
			{
				RadMessageBox.Show("Your request must be at least 40 characters long.");
				return;
			}
			this.txtTitle.Text = this.txtTitle.Text.Trim();
			this.txtRemarks.Text = this.txtRemarks.Text.Trim();
			this.txtEmail.Text = this.txtEmail.Text.Trim();
			string value = this.chkSyslog.Checked ? GClass6.smethod_18() : "No data provided";
			if (this.txtTitle.Text == "")
			{
				RadMessageBox.Show("Please provide a short description of the issue.");
				return;
			}
			if (this.txtRemarks.Text.Length < 40)
			{
				RadMessageBox.Show("Your request must be at least 40 characters long.");
				return;
			}
			if (!this.method_1(this.txtEmail.Text))
			{
				RadMessageBox.Show("You must specify a valid email address, otherwise we can't reply to you!");
				return;
			}
			string text = this.txtRemarks.Text.Trim();
			text += Environment.NewLine;
			foreach (ListViewDataItem listViewDataItem in this.lstTitles.CheckedItems)
			{
				text = text + listViewDataItem.Tag + Environment.NewLine;
			}
			if (this.chkTeamViewer.Checked)
			{
				text = text + Environment.NewLine + string.Format("The user has requested a TeamViewer Session at {0}.", TimeZoneInfo.ConvertTimeFromUtc(this.timeViewer.Value.ToUniversalTime(), TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time")));
			}
			if (this.string_0 != null)
			{
				text = text + Environment.NewLine + Environment.NewLine + this.string_0;
			}
			string text2 = GClass6.smethod_20(string.Format("{0}/issue/open_issue.php", Class65.String_4), new NameValueCollection
			{
				{
					"email",
					this.txtEmail.Text
				},
				{
					"app_id",
					Settings.Default.AppId
				},
				{
					"title",
					this.txtTitle.Text
				},
				{
					"syslog",
					value
				}
			});
			try
			{
				uint.Parse(text2);
			}
			catch
			{
				RadMessageBox.Show("Sorry but we are unable to process your request at the moment");
				return;
			}
			string text3 = GClass6.smethod_20(string.Format("{0}/issue/answer_issue.php", Class65.String_4), new NameValueCollection
			{
				{
					"issue_id",
					text2
				},
				{
					"message",
					text
				}
			});
			try
			{
				uint.Parse(text3);
			}
			catch
			{
				RadMessageBox.Show("Sorry but we are unable to process your request at the moment");
				return;
			}
			foreach (string sourceFileName in this.list_0)
			{
				try
				{
					string text4 = Path.Combine(GClass88.CachePath, text3);
					File.Copy(sourceFileName, text4, true);
					Encoding.UTF8.GetString(new WebClient().UploadFile(string.Format("{0}/issue/upload.php", Class65.String_4), text4));
				}
				catch
				{
				}
			}
			RadMessageBox.Show(string.Format("<html>Thank you for contacting us!\nYou will be notified by email (make sure to check your spam box) when a reply is available.\nYour issue id is : {0}\nYou can follow its status <a href=\"{1}/issue/view/view.php?issue_id={2}\">here</a>.\nPlease keep it for future reference.<html>", text2, Class65.String_4, text2));
			base.Close();
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x000480C0 File Offset: 0x000462C0
		private void radButton7_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.CheckFileExists = true;
			openFileDialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (new FileInfo(openFileDialog.FileName).Length > 3000000L)
				{
					RadMessageBox.Show("This file is too big");
					return;
				}
				if (!this.list_0.Contains(openFileDialog.FileName))
				{
					this.list_0.Add(openFileDialog.FileName);
					this.lblProvided.Text = string.Format("{0} file(s) provided", this.list_0.Count);
				}
			}
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0004815C File Offset: 0x0004635C
		private void radTextBox1_TextChanged(object sender, EventArgs e)
		{
			this.lstTitles.EnableFiltering = true;
			this.lstTitles.FilterDescriptors.Clear();
			this.lstTitles.FilterDescriptors.Add(new FilterDescriptor("Text", FilterOperator.Contains, this.radTextBox1.Text));
		}

		// Token: 0x04000742 RID: 1858
		private string string_0;

		// Token: 0x04000743 RID: 1859
		private List<string> list_0 = new List<string>();
	}
}
