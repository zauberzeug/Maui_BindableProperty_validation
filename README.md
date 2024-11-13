Minimal reproduction example demonstrating a .NET MAUI bug where BindableProperty's validateValue callback doesn't throw ArgumentException when returning false. 
According to docs, this should raise an exception, but it doesn't. 
Includes simple custom control example to verify the behavior.
