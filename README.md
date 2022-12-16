# CreedSeedBackend
The Backend for the Church Planning and Content Distribution Platform

## About the Project
This Project is desigend to be an open source project. 
Currently it is in the early proof of concept stages and is developed in the spare time.
If you would like to join this project, feel free to contact me in English or German.


## Vision
I see a need for churches in Europe to freely use a tool which allows them to organize their members, their events
and manage their content and make it available to their community, like sermons, videos, trainings, documentations etc.
or to publish certan information publicly while making maintaining the DSGVO and making it easy for the user to comply to it. 

It needs secure and easy access via a simple to use app on any device.


## Planned Technology Stack
The Backend is done in C# .Net Core, based on Orchard Core and is responsible for designing the data structure. 
The admin backend of Orchard Core is not intended to be used by the user. 
Content will rather be created via the CreedSeedClient.
The backend provides a GraphQl Api where all content management will be done through.

The Client will be realised with Angular including the Ionic Framework, where the app at first will be a PWA (Progressive Web App) which can easly be installed on any device.



