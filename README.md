This project demonstrates the issue described in [Microsoft Connect Issue #1604718][1].

An `ArgumentException` is thrown when adding headers to a `System.Net.Mail.MailMessage` 
if either the `name` or `value` arguments is `string.Empty`. This is expected behavior. 

However, if `value` is the offending argument, the `ParamName` property of the thrown 
exception is `name`. `ParamName` should be `value`, since the `value` argument is the 
offending parameter.

The sample provided is a console application. To execute the sample, open the project
in Visual Studio and run the application.

[1]: https://connect.microsoft.com/VisualStudio/feedback/details/1604718/argumentexception-blames-wrong-parameter-for-invalid-input