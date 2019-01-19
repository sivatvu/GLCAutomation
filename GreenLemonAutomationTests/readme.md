# Selenium Web Test Example



### app.config
In _configuration/appSettings/browser_ the used browser is configured. This value is changed by a ConfigFileTransformation in the **Default.srProfile**

### Default.srprofile

#### Targets
3 Targets (one for every browser) are defined here. They have a filter on the tag _Browser_\_**__{BrowserName}__**, so only scenarios with the tag is executed in this target.

#### DeploymentSteps
2 deployment steps are configured
1. IISExpress - this starts a IIS Express instance, so you do not have to check it manually that it is running
2. ConfigFileTransformation - this sets the _configuration/appSettings/browser_ to the target name


### WebDriver.cs
This driver provides you access to the appropriate Selenium WebDriver. It uses the _configuration/appSettings/browser_ value for this.
To get access to the Selenium Web Driver, use the _Current_ property on it. Use [Context Injection](http://www.specflow.org/documentation/Context-Injection/) to get the instance.



```
