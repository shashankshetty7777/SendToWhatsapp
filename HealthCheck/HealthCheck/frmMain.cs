using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace HealthCheck
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void BtnSend_Click(object sender, EventArgs e)
		{
			const string ACCOUNT_TOKEN = "8e308f74a1c4757881e92e1d649f08c7";
			const string ACCOUNT_SID = "ACdbcef5652b7df21ce60ccabb39ae26c1";
			TwilioClient.Init(ACCOUNT_SID,ACCOUNT_TOKEN);
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
												| SecurityProtocolType.Tls11
												| SecurityProtocolType.Tls12
												| SecurityProtocolType.Ssl3;
			var message = MessageResource.Create(
				from: new PhoneNumber("whatsapp:+14155238886"),
				to: new PhoneNumber("whatsapp:+918898463955"),
				body: "Hi shashank"
				);

			Console.WriteLine("Message Sid" + message.Sid);
		}
	}


}
