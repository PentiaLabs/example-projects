# example-projects
Contains example structures for projects, mostly front-end wise as of now.


We always want to follow back-ends structure as pictured here:

```
www  
│
└───Components
    ├───Framework
    ├───Domain
    └───Project

```


## frontend-components
An example of frontend components that lives with the backend code. But in it's own sub folder `Client`.

```
www  
│
└───Components
    │
    ├───Framework
    │   ├───FrontendComponentLoader (require ect.)
    │   ├───CustomInputs\Client
    │   │   ├──── CustomInputs.less
    │   │   └──── main.js
    │   └───FormValidation\Client
    │       ├──── CustomInputs.less
    │       └──── main.js
    │
    ├───Domain
    │   ├───NewsFeed\Client
    │   │   ├──── Feed.less
    │   │   └──── main.js
    │   └───Accordion
    │       ├──── Web.config  
    │       ├──── Accordion.csproj 
    │       ├───Presentation
    │       │   ├──── ViewModels/..
    │       │   └──── Accordion.cshtml
    │       └───Client
    │           ├──── Accordion-image-static.png
    │           ├──── Accordion.scss
    │           ├──── Accordion.swig
    │           └──── Accordion.js
    └───Project
        └───ClientDependencies
            └──── bower_components

```