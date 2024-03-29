# TakeNotesAppDev

# Table of Contents
1. [Overview](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Overview)
   - a) [Purpose](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Purpose)
   - b) [Function](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Function)
2. [Project Requirements Table](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Project-Requirements-Table)
3. [Solution Architect Diagram](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Solution-Architect-Diagram)
4. [WireFrames](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#WireFrames)
   - a) [Creating a New Account](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Creating-a-New-Account)
   - b) [Log into Account](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Log-Into-Account)
   - c) [Home Dashboard - Sticky Notes View](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Home-Dashboard-Sticky-Notes-View)
   - d) [Home Dashboard - List View](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Home-Dashboard-List-View)
   - e) [Create Edit Note](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Create-Edit-Note)
5. [User Stories and Use Cases](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#User-Stories-and-Use-Cases)
   - a) [User Stories](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#User-Stories)
   - b) [Use Cases](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Use-Cases)
   - c) [Use Case Diagram](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Use-Case-Diagram)
6. [Database Design](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Database-Design)
   - a) [Chen Model Entity Relationship Diagram](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Chen-Model-Entity-Relationship-Diagram)
   - b) [UML Class Diagram](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#UML-Class-Diagram)
7. [Data Access Layer](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Data-Access-Layer)
   - a) [Note Class Code](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Note-Class-Code)
   - b) [Note Controller](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Note-Controller)
   - c) [http Response](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#http-Response)


# Overview

### Purpose
The purpose of the TakeNotes application will be to keep simple notes, images, and ideas in the form of a post-it note board.  I would eventually like to consider the option of cloud support, allowing this application to be cross platform, however, for the moment I will be focusing on single platform.  This application should allow the user to organize and archive their notes as needed. 


### Function
Much like Google Keep, I would like to create a board (home page) that allows the user to click on an icon and create a new note.  This home page would display all notes relevant to the user.  Notes could have color background options for grouping, and new notes can be text or image.  Notes could also be organized by label, files, or archive.  Google Keep currently only organizes by label - which will display groups of notes flagged with the same label; and archive – a file notes can be sent when the user wants to remove them from the main board.  There is however, no current option for creating files from the main board or within the archive, which I would like to add in this application.  Users will have the ability to add or delete notes as needed.  Additional features that I would also like to include would be bullet list creation, alerts, and the ability to send notes via email.
<br>
<br>
[Back to Top](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Table-of-Contents)

# Project Requirements Table

|ID Number| Requirement|
| :---: | --- |
| 001 | The software shall allow the user to create a new account using an email address and password of their choice so long as it meets criteria |
| 002 | The software shall allow the user to access their created account using the email and password chosen at the time of creation | 
| 003 | The software shall, upon log in, display all of the users previous, non-archived notes and reminders |
| 004 | The software shall allow the user to create a new note when clicking on the appropriate icon |
| 005 | The software shall allow the user to alter their dashboard display view when clicking on the appropriate icon. Users shall be allowed to toggle between note and list view |
| 006 | The software shall allow the user to create new folders for sorting and storing notes away from the main dashboard by clicking on the appropriate icon |
| 007 | The software shall allow users to move notes from folders to dashboard to archive freely by clicking on the appropriate icon |
| 008 | The software shall allow users to delete a note by clicking on the appropriate icon, giving a warning message before deletion |  


[Back to Top](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Table-of-Contents)
<br>

# Solution Architect Diagram
As this is a very simple application, the actors would mainly consist of: the user, the database, and potentially the site administrator.
![Solution Architect Diagram](https://github.com/EmHarris589/TakeNotesAppDev/blob/8b2fa0768b9fa904a6838ac12f76b9e6db748da7/TakeNotes_SolutionArchitectDiagram.PNG)


[Back to Top](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Table-of-Contents)
<br>

# WireFrames
### Creating a New Account - DRAFT
Users would view this screen when creating a new account.
![Creating a New Account](https://github.com/EmHarris589/TakeNotesAppDev/blob/73279f4bed379f8936418c89849bf7776919cee4/CreateAccount_WF.PNG) 
### Log Into Account - DRAFT
Users would view this screen when logging in to thier existing account.
![Log Into Account](https://github.com/EmHarris589/TakeNotesAppDev/blob/dbe4437830441d543ba07f1ddc70becbb039d447/LogIn_WF.PNG)
### Home Dashboard - Sticky Notes View - DRAFT
Users would view this screen as their landing/home page upon log in.
![Home Dashboard Sticky View](https://github.com/EmHarris589/TakeNotesAppDev/blob/dbe4437830441d543ba07f1ddc70becbb039d447/HomePage_WF.PNG)
### Home Dashboard - List View - DRAFT
This is a second option for viewing the landing/home page.
![Home Dashboard List View](https://github.com/EmHarris589/TakeNotesAppDev/blob/dbe4437830441d543ba07f1ddc70becbb039d447/ListView_WF.PNG)
### Create/Edit Note View - DRAFT
Users would view this screen when creating or editing a note.
![Create Edit Note](https://github.com/EmHarris589/TakeNotesAppDev/blob/dbe4437830441d543ba07f1ddc70becbb039d447/SelectedNote_WF.png)
<br>
<br>
[Back to Top](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Table-of-Contents)
<br>

# User Stories and Use Cases
User Stories and Use Cases include the following actions:  Creating an account, Logging into an exisiting account, Creating a new note, Editing an existing note, Creating a file, Moving a note to the Archive, and Deleting a note.

### User Stories
[User Stories can be found here](https://github.com/EmHarris589/TakeNotesAppDev/blob/a8189b43b04e7d6259da17af9836cac735eee8c4/TakeNotes_UserStories.pdf)
<br>
<br>
[Back to Top](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Table-of-Contents)
<br>
### Use Cases
[Use Cases can be found here](https://github.com/EmHarris589/TakeNotesAppDev/blob/a8189b43b04e7d6259da17af9836cac735eee8c4/TakeNotes_UseCases.pdf)
<br>
<br>
[Back to Top](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Table-of-Contents)
<br>
### Use Case Diagram
![Use Cases Diagram](https://github.com/EmHarris589/TakeNotesAppDev/blob/a8189b43b04e7d6259da17af9836cac735eee8c4/TakeNotes_UseCaseDiagram.PNG)
<br>
<br>
[Back to Top](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Table-of-Contents)
<br>
## Database Design

### Chen Model Entity Relationship Diagram
![ChenERD](https://github.com/EmHarris589/TakeNotesAppDev/blob/2f8108e5857ad460ace8452761d12a8a59346aab/TakeNotes_ERD_ChenNotation.PNG)
<br>
<br>
[Back to Top](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Table-of-Contents)
<br>
### UML Class Diagram
![UML Class Diagram](https://github.com/EmHarris589/TakeNotesAppDev/blob/5ade8dc13405c00e8402c72f5a2bc5cd8b8ebff0/TakeNotes_ClassDiagram.PNG)
<br>
<br>
[Back to Top](https://github.com/EmHarris589/TakeNotesAppDev/blob/main/README.md#Table-of-Contents)
<br>

# Data Access Layer

### Note Class Code
![Note Class Code](https://github.com/EmHarris589/TakeNotesAppDev/blob/161e0f833faae31b5cdc287ff6efd771ef45386a/Note.cs_1of2.PNG)
![Note Class Code2](https://github.com/EmHarris589/TakeNotesAppDev/blob/020918b7178174e7edc9cd190eadbac1a22f8fa6/note.cs_2of2.PNG)

### Note Controller Code
![Note Controller Code](https://github.com/EmHarris589/TakeNotesAppDev/blob/46e69496b02a4f24122424de3c28dd004632d8c4/NoteController.PNG)

### HTTP Response
![http Response](https://github.com/EmHarris589/TakeNotesAppDev/blob/c96828841471599b16fae9d9c9f1164b755f5f66/http_response.PNG) 



