# FaceOffers-SDK-2

FACEOFFERS SDK 2 & Sample console app for ASP.Net. 

Using the SDK, you can easily call all the FACEOFFERS REST API endpoints. The console app is a sample app that contains methods for authenticating with the REST API. It also contains some sample calls. 

This is an ASP.net SDK for the FACEOFFERS platform. The SDK was built using the ASP.net 4.5 framework. 

To create a FREE FACEOFFERS account, click here. https://portal.faceoffers.com/

To access the API documentation click here. http://api.faceoffers.com/ 

For support, click here. https://faceoffers.jitbit.com/ To create a support ticket, login to your FACEOFFERS account and click on the Support menu item. 

When using the SDK in an app that is not a console app, remove the .Result from the following line and use await instead. Using .Result could result in a deadlock.

bool result = service.Login(faceoffersUsername, faceoffersPassword).Result;

bool result = await service.Login(faceoffersUsername, faceoffersPassword);
