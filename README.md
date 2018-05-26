# Mailbox Category List Manager

The Master Category List Manager provides a GUI interface to access the _master category list_ of an Exchange mailbox. The master category list to used to populate the list of available categories for labeling of messages, appointments, meetings, and other objects.

The project is provided as a Visual Studio solution with the following requirements

* .NET Framework 4.6.1

Code libraries part of the solution:

* Exchange Web Services API 
* log4net

## Functionality

The Category List Manager allows you top connect to a source mailbox which is either hosted on an on-premises Exchange Server or in Exchange Online using Exchange Web Services (_EWS_). You can use AutoDiscover or a static Url to connect to the Exchange Server.

By default the solution uses the credentials of the user executing the program. These credentials are referred to as _default credentials_. You can use the _Settings_ form to set dedicated credentials of an user with appropriate access rights to the mailbox(es).

The program helps you to

* Export the master category list from a mailbox to a Xml file
* Import a master category list Xml file to into a mailbox
* Copy a master category list from a source mailbox to a target mailbox

The suported _target_ mailbox types are:

* User Mailbox
* Shared Mailbox
* Microsoft Teams Mailbox

The GUI comes with an easy-to-use UI. The functionality is described in the next paragraphs.

### Main Form

![Category List Manager - Main Form](https://github.com/Apoc70/MailboxCategoryListManager/blob/master/DocumentationImages/01-ManageCategories-StartScreen.png)

The main form provides a text box for the _email address_ for the mailbox to connect to. You can use the checkbox to connect to the mailbox using EWS _impersonation_.

![Category List Manager - Connect to a mailbox](https://github.com/Apoc70/MailboxCategoryListManager/blob/master/DocumentationImages/03-ManageCategories-ConnectMailbox.png)

Use the _Connect_ button to connect to the mailbox using the settings configured in the _Settings_ form.

![Category List Manager - Connected mailbox](https://github.com/Apoc70/MailboxCategoryListManager/blob/master/DocumentationImages/03a-ManageCategories-ConnectedMailbox.png)

After the EWS connection has been established sucessfully, the EWS target Url is displayed in the status bar.

A successfully connected mailbox enables the _Import/Export_ and _Copy_ tabs.

#### Export/Import

![Category List Manager - Import/Export](https://github.com/Apoc70/MailboxCategoryListManager/blob/master/DocumentationImages/05-ManageCategories-Import-Export.png)

Use the _Import_ button to select an existing master category list Xml file for import into the mailbox you are connected to.

The _Clear master category list before import_ checkbox enables the deletion of all existing categories before import. If you do _not_ activate this checkbox the categories are added to the exisiting categories.

Use the _Export_ button to export the master category list of the mailbox you are connected to.

#### Copy

![Category List Manager - Copy](https://github.com/Apoc70/MailboxCategoryListManager/blob/master/DocumentationImages/04-ManageCategories-Copy.png)

The tab _Copy_ allows for copying the master category list from the mailbox you are connected to into another mailbox.

Enter the email address of the _target mailbox_ and select wether you want to use impersonation. CLick the _Copy_ button to copy the master category list into the target mailbox.

The _Clear master category list before import_ checkbox enables the deletion of all existing categories in the target mailboxbefore import. If you do _not_ activate this checkbox the categories are added to the exisiting categories.

### Settings Form

![Category List Manager - Settings](https://github.com/Apoc70/MailboxCategoryListManager/blob/master/DocumentationImages/02a-ManageCategories-Settings-Overview.png)

Use the _Settings_ form to provide static credentials for connecting to Exchange and provide manual EWS connection information.

![Category List Manager - Settings - Credentials](https://github.com/Apoc70/MailboxCategoryListManager/blob/master/DocumentationImages/02c-ManageCategories-Settings-Credentials.png)

If you want to provide static credentials deactivate the _Use default credentials_ checkbox and enter the _username_ and _password_.



Changes made to the settings configuration are saved by clicking the _OK_ button.

The settings are persisted. The password provided is encrypted using AES 256 encryption.


