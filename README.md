# Workflow Email Approval Sample

This is the code from my blog post describing a [workflow based email approval app](http://blog.petegoo.com/index.php/2010/08/22/workflow-4-email-approval-sample/)

## Pre-requisites
1. Use a local SMTP / email server like [Papercut](http://papercut.codeplex.com/) so that you can send emails from the workflow and see them appear.

## Running the sample
1. Run the code.
2. Check your email app (Papercut).
3. You should see 3 emails, approve or decline as desired.
4. You should receive another email summarising the approval responses once they are all complete.

## Common Issues
Check that you have the correct URLs in the code. Visual Studio may decide to use different ports. URLs are hard coded at the following locations

* ApproverClient\app.config
* ApprovalWorkflow\Workflow.xamlx (Send Approval Email activity)
* Approval.Web\Web.config

If you decide to push this into IIS rather than IIS Express, the above URLs will change.