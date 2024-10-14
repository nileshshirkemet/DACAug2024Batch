namespace DemoApp;

//a value (struct) type record exposes settable
//properties unless defined with 'readonly' keyword
readonly record struct Developer(string Name, string Degree, string Location, string Language);
