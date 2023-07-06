// See https://aka.ms/new-console-template for more information
using Custom_Exception_Codes.exceptions;
using Custom_Exception_Codes.exceptions.resources;
using Custom_Exception_Codes.exceptions.resources.database;
using Custom_Exception_Codes.exceptions.resources.cache;

try
{
    Random random = new Random();
    int randomNumber = random.Next(1, 7);

    switch (randomNumber)
    {
        case 1:
            throw new ResourceException("resource general error");

        case 2:
            throw new DatabaseResourceException("database general error");

        case 3:
            throw new DatabaseTimeoutException("database timeout error");

        case 4:
            throw new CacheResourceException("cache general exception");

        case 5:
            throw new CacheUnauthorizedException("cache unauthorized error");

        default:
            throw new GeneralException("general error");
    }
}
catch( Exception e)
{
    Console.WriteLine(e.Message);
}