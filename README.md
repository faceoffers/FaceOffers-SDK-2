# FaceOffers-SDK-2

This readme file is a work in process.

When using the SDK in an app that is not a console app, remove the .Result from the following line and use await instead. Using .Result could result in a deadlock.

bool result = service.Login(faceoffersUsername, faceoffersPassword).Result;

bool result = await service.Login(faceoffersUsername, faceoffersPassword);
