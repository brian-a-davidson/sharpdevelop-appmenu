/*
 * Created by SharpDevelop.
 * User: davidsonb
 * Date: 3/10/2016
 * Time: 8:45 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Cubic_Appmenu
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void statusButtonClick(object sender, EventArgs e)
		{
				if (string.IsNullOrEmpty(serverBox.Text) || string.IsNullOrEmpty(userBox.Text)|| string.IsNullOrEmpty(pwdBox.Text))
				{
 	           	MessageBox.Show("Please enter Server Name/User Name/Password to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);			
				}
				else
				{
				string node;
				string password;
				string plink;
				string username;
				string statusall;
				string menulog;
				string menutitle;
				string script_name;
				script_name = " /opt/cubic_appmenu/scripts/appstatus_config.sh";
				node = serverBox.Text;
				password = pwdBox.Text;
				username = userBox.Text;
				menutitle = @" title Cubic Apppmenu-------------------------------------------------------------------------------------------- &";
				menulog = @" >> C:\Cubic_Appmenu\config\cubic_appmenu.log & ";
				plink = @" c:\Cubic_Appmenu\config\plink.exe";
				statusall = @"/K echo %date%:%time% %username% checked application status on " + node + menulog + menutitle + plink + " -P 22 " + node + " -pw " + password + " -l " + username + script_name;
				System.Diagnostics.Process.Start("CMD.exe",statusall);				
				}
		}
		void stopButtonClick(object sender, EventArgs e)
		{
				if (string.IsNullOrEmpty(serverBox.Text) || string.IsNullOrEmpty(userBox.Text) || string.IsNullOrEmpty(pwdBox.Text) || string.IsNullOrEmpty(appBox.Text))
				{
 	           	MessageBox.Show("Please enter Server Name/User Name/Password/Application Name to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);			
				}
				else
				{
				string node;
				string password;
				string plink;
				string app;
				string username;
				string stopapp;
				string menulog;
				string menutitle;
				string script_name;
				script_name = " /opt/cubic_appmenu/scripts/appmenu_main.sh ";
				node = serverBox.Text;
				username = userBox.Text;
				password = pwdBox.Text;
				app = appBox.Text;
				menutitle = @" title Cubic Apppmenu-------------------------------------------------------------------------------------------- &";
				menulog = @" >> C:\Cubic_Appmenu\config\cubic_appmenu.log & ";
				plink = @" c:\Cubic_Appmenu\config\plink.exe";
				DialogResult dialog = MessageBox.Show("Do you want to stop the " + app + " application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				
				if (dialog == DialogResult.Yes)
				{
				stopapp = @"/K echo %date%:%time% %username% stopped " + app + " application on " + node + menulog + menutitle +  plink + " -P 22 " + node + " -pw " + password + " -l " + username + script_name + app + " wstop " + password;
				System.Diagnostics.Process.Start("CMD.exe",stopapp);
				}				
				}
		}
		void startButtonClick(object sender, EventArgs e)
		{
				if (string.IsNullOrEmpty(serverBox.Text) || string.IsNullOrEmpty(userBox.Text) || string.IsNullOrEmpty(pwdBox.Text) || string.IsNullOrEmpty(appBox.Text))
				{
 	           	MessageBox.Show("Please enter Server Name/User Name/Password/Application Name to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);			
				}
				else
				{
				string node;
				string password;
				string plink;
				string app;
				string username;
				string startapp;
				string menulog;
				string menutitle;
				string script_name;
				script_name = " /opt/cubic_appmenu/scripts/appmenu_main.sh ";
				node = serverBox.Text;
				username = userBox.Text;
				password = pwdBox.Text;
				app = appBox.Text;
				menutitle = @" title Cubic Apppmenu-------------------------------------------------------------------------------------------- &";
				menulog = @" >> C:\Cubic_Appmenu\config\cubic_appmenu.log & ";
				plink = @" c:\Cubic_Appmenu\config\plink.exe";
				DialogResult dialog = MessageBox.Show("Do you want to start the " + app + " application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				
				if (dialog == DialogResult.Yes)
				{
				startapp = @"/K echo %date%:%time% %username% started " + app + " application on " + node + menulog + menutitle + plink + " -P 22 " + node + " -pw " + password + " -l " + username + script_name + app + " wstart " + password;
				System.Diagnostics.Process.Start("CMD.exe",startapp);
				}
				}
		}
		void statusappButtonClick(object sender, EventArgs e)
		{
				if (string.IsNullOrEmpty(serverBox.Text) || string.IsNullOrEmpty(userBox.Text) || string.IsNullOrEmpty(pwdBox.Text) || string.IsNullOrEmpty(appBox.Text))
				{
 	           	MessageBox.Show("Please enter Server Name/User Name/Password/Application Name to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);			
				}
				else
				{
				string node;
				string password;
				string plink;
				string app;
				string username;
				string statusapp;
				string menulog;
				string menutitle;
				string script_name;
				script_name = " /opt/cubic_appmenu/scripts/appmenu_main.sh ";
				node = serverBox.Text;
				username = userBox.Text;
				password = pwdBox.Text;
				app = appBox.Text;
				menutitle = @" title Cubic Apppmenu-------------------------------------------------------------------------------------------- &";
				menulog = @" >> C:\Cubic_Appmenu\config\cubic_appmenu.log & ";
				plink = @" c:\Cubic_Appmenu\config\plink.exe";
				statusapp = @"/K echo %date%:%time% %username% checked status for " + app + " application on " + node + menulog + menutitle + plink + " -P 22 " + node + " -pw " + password + " -l " + username + script_name + app + " wstatus " + password;
				System.Diagnostics.Process.Start("CMD.exe",statusapp);	
				}
		}
		void killButtonClick(object sender, EventArgs e)
		{
				if (string.IsNullOrEmpty(serverBox.Text) || string.IsNullOrEmpty(userBox.Text) || string.IsNullOrEmpty(pwdBox.Text) || string.IsNullOrEmpty(appBox.Text))
				{
 	           	MessageBox.Show("Please enter Server Name/User Name/Password/Application Name to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);			
				}
				else
				{
				string node;
				string password;
				string plink;
				string app;
				string username;
				string killapp;
				string menulog;
				string menutitle;
				string script_name;
				script_name = " /opt/cubic_appmenu/scripts/logmenu_main.sh ";
				node = serverBox.Text;
				username = userBox.Text;
				password = pwdBox.Text;
				app = appBox.Text;
				menutitle = @" title Cubic Apppmenu-------------------------------------------------------------------------------------------- &";
				menulog = @" >> C:\Cubic_Appmenu\config\cubic_appmenu.log & ";
				plink = @" c:\Cubic_Appmenu\config\plink.exe";
				DialogResult dialog = MessageBox.Show("Do you want to kill the " + app + " application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				
				if (dialog == DialogResult.Yes)
				{
					killapp = @"/K echo %date%:%time% %username% killed " + app + " application on " + node + menulog + menutitle + plink + " -P 22 " + node + " -pw " + password + " -l " + username + script_name + app + " wkill " + password;
				    System.Diagnostics.Process.Start("CMD.exe",killapp);
				}
				}	
		}
		void viewButtonClick(object sender, EventArgs e)
		{
				if (string.IsNullOrEmpty(serverBox.Text) || string.IsNullOrEmpty(userBox.Text) || string.IsNullOrEmpty(pwdBox.Text) || string.IsNullOrEmpty(appBox.Text))
				{
 	           	MessageBox.Show("Please enter Server Name/User Name/Password/Application Name to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);			
				}
				else
				{
				string node;
				string password;
				string plink;
				string app;
				string username;
				string viewlog;
				string menutitle;
				string script_name;
				script_name = " /opt/cubic_appmenu/scripts/logmenu_main.sh ";
				node = serverBox.Text;
				username = userBox.Text;
				password = pwdBox.Text;
				app = appBox.Text;
				menutitle = @"/K title Cubic Apppmenu-------------------------------------------------------------------------------------------- &";
				plink = @" c:\Cubic_Appmenu\config\plink.exe";
				viewlog = menutitle + plink + " -P 22 " + node + " -pw " + password + " -l " + username + script_name + app + " wlog " + password;
				System.Diagnostics.Process.Start("CMD.exe",viewlog);	
				}	
		}
		void viewdashButtonClick(object sender, EventArgs e)
		{
			MessageBoxManager.Yes = "Production";
			MessageBoxManager.No = "Staging";
			MessageBoxManager.Register();
			DialogResult dialog = MessageBox.Show("Which dashboard do you want to launch?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
			MessageBoxManager.Unregister();
			
			if (dialog == DialogResult.Yes)
				{
					string dashboard;
					dashboard = @"/C start config/prod_dashboard.url";
				    System.Diagnostics.Process.Start("CMD.exe",dashboard);
				}
				else if (dialog == DialogResult.No)
				{
					string dashboard;
					dashboard = @"/C start config/stage_dashboard.url";
				    System.Diagnostics.Process.Start("CMD.exe",dashboard);
				}
		}
		void pingButtonClick(object sender, EventArgs e)
		{
				if (string.IsNullOrEmpty(serverBox.Text))
				{
 	           	MessageBox.Show("Please enter Server Name/IP Address to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);			
				}
				else
				{
				string node;
				string ping;
				node = serverBox.Text;
				ping = @"/K ping " + node;
				System.Diagnostics.Process.Start("CMD.exe",ping);	
				}					
		}
		void CpingButtonClick(object sender, EventArgs e)
		{
				if (string.IsNullOrEmpty(serverBox.Text))
				{
 	           	MessageBox.Show("Please enter Server Name/IP Address to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);			
				}
				else
				{
				string node;
				string ping;
				node = serverBox.Text;
				ping = @"/K ping -t " + node;
				System.Diagnostics.Process.Start("CMD.exe",ping);	
				}
		}
		void LookupButtonClick(object sender, EventArgs e)
		{
				if (string.IsNullOrEmpty(serverBox.Text))
				{
 	           	MessageBox.Show("Please enter Server Name/IP Address to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);			
				}
				else
				{
				string node;
				string ping;
				node = serverBox.Text;
				ping = @"/K nslookup " + node;
				System.Diagnostics.Process.Start("CMD.exe",ping);	
				}	
		}
		void TrouteButtonClick(object sender, EventArgs e)
		{
				if (string.IsNullOrEmpty(serverBox.Text))
				{
 	           	MessageBox.Show("Please enter Server Name/IP Address to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);			
				}
				else
				{
				string node;
				string ping;
				node = serverBox.Text;
				ping = @"/K tracert " + node;
				System.Diagnostics.Process.Start("CMD.exe",ping);	
				}	
		}
		void ThreadDumpbuttonClick(object sender, EventArgs e)
		{
				if (string.IsNullOrEmpty(serverBox.Text) || string.IsNullOrEmpty(userBox.Text) || string.IsNullOrEmpty(pwdBox.Text) || string.IsNullOrEmpty(appBox.Text))
				{
 	           	MessageBox.Show("Please enter Server Name/User Name/Password/Application Name to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);			
				}
				else
				{
				string node;
				string password;
				string plink;
				string app;
				string username;
				string dumpapp;
				string menulog;
				string menutitle;
				string script_name;
				script_name = " /opt/cubic_appmenu/scripts/logmenu_main.sh ";
				node = serverBox.Text;
				username = userBox.Text;
				password = pwdBox.Text;
				app = appBox.Text;
				menutitle = @" title Cubic Apppmenu-------------------------------------------------------------------------------------------- &";
				menulog = @" >> C:\Cubic_Appmenu\config\cubic_appmenu.log & ";
				plink = @" c:\Cubic_Appmenu\config\plink.exe";
				DialogResult dialog = MessageBox.Show("Do you want to thread dump the " + app + " application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				
				if (dialog == DialogResult.Yes)
				{
					dumpapp = @"/K echo %date%:%time% %username% thread dump " + app + " application on " + node + menulog + menutitle + plink + " -P 22 " + node + " -pw " + password + " -l " + username + script_name + app + " wdump " + password;
				    System.Diagnostics.Process.Start("CMD.exe",dumpapp);
				}
				}	
		}

		
		void ClearCNGbuttonClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(serverBox.Text))
				{
 	           	MessageBox.Show("Please enter CNG server name to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);			
				}
				else
				{
				string node;
				string cng1;
				string cng2;
				string cng3;
				string cng4;
				string cng5;
				string cng6;
				string cng7;
				string cng8;;
				cng1 = "ctac-cng1";
				cng2 = "ctac-cng2";
				cng3 = "ctae-cng1";
				cng4 = "ctae-cng2";
				cng5 = "ctas-apps2";
				cng6 = "ctas-apps3";
				cng7 = "ctas-apps5";
				cng8 = "ctas-apps6";
				node = serverBox.Text.ToLower();
				if (node.Equals(cng1) || node.Equals(cng2) || node.Equals(cng3) || node.Equals(cng4) || node.Equals(cng5) || node.Equals(cng6) || node.Equals(cng7) || node.Equals(cng8))
					{
					string clearcng;
					clearcng = @"/C start " + " http://" + node + ":8901/manager/jmxproxy/?invoke=org.apache.activemq:type=Broker,brokerName=cngBroker,destinationType=Queue,destinationName=ActiveMQ.DLQ^&op=purge";
					System.Diagnostics.Process.Start("CMD.exe",clearcng);
					}
					else
					{
					MessageBox.Show("Please enter valid CNG server name to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}

				}
		}
		
		void MainFormHelpButtonClicked(object sender, EventArgs e)			
		{
			string cch;
			string prodcat;
			string cpa;
			string cng;
			string oms;
			string nis;
			string cdcs;
			string ec;
			string pal;
			string ncs;
			string rmq;
			string appname;
			appname = "Application Name \t\t: Appmenu Name\n";
			cch = "ClearingHouse \t\t: CCH \n";
			prodcat = "Product Catalog \t\t: PRODCAT \n";
			cng = "Cubic Notification Gateway \t: CNG \n";
			cpa = "Cubic Payment Application \t: CPA \n";
			oms = "Order Management System \t: OMS \n";
			nis = "Next Integration Service \t: NIS \n";
			cdcs = "Central Device Comm Server \t: CDCS \n";
			ec = "Event Collector \t\t: EC \n";
			pal = "Payment Abstraction Layer \t: PAL \n";
			ncs = "Nextfare Central System \t: NCS \n";
			rmq = "RabbitMQ \t\t: RMQ \n";
		    MessageBox.Show(appname + cch + prodcat + cng + oms + cpa + nis + cdcs + ec + pal + ncs + rmq, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
}
}