# TakeNotesAppDev

# Table of Contents
1. Overview
   - a) Purpose
   - b) Function
2. Project Requirements Table
3. Solution Architect Diagram
4. WireFrames
   - a) Creating a New Account
   - b) Log into Account
   - c) Home Dashboard - Sticky Notes View
   - d) Home Dashboard - List View
   - e) Create Edit Note
5. User Stories and Use Cases
   - a) User Stories
   - b) Use Cases
   - c) Use Case Diagram

# Overview

### Purpose
The purpose of the TakeNotes application will be to keep simple notes, images, and ideas in the form of a post-it note board.  I would eventually like to consider the option of cloud support, allowing this application to be cross platform, however, for the moment I will be focusing on single platform.  This application should allow the user to organize and archive their notes as needed. 

### Function
Much like Google Keep, I would like to create a board (home page) that allows the user to click on an icon and create a new note.  This home page would display all notes relevant to the user.  Notes could have color background options for grouping, and new notes can be text or image.  Notes could also be organized by label, files, or archive.  Google Keep currently only organizes by label - which will display groups of notes flagged with the same label; and archive – a file notes can be sent when the user wants to remove them from the main board.  There is however, no current option for creating files from the main board or within the archive, which I would like to add in this application.  Users will have the ability to add or delete notes as needed.  Additional features that I would also like to include would be bullet list creation, alerts, and the ability to send notes via email.

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


# Solution Architect Diagram
As this is a very simple application, the actors would mainly consist of: the user, the database, and potentially the site administrator.
![Solution Architect Diagram](https://github.com/EmHarris589/TakeNotesAppDev/blob/8b2fa0768b9fa904a6838ac12f76b9e6db748da7/TakeNotes_SolutionArchitectDiagram.PNG)

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

# User Stories and Use Cases
User Stories and Use Cases include the following actions:  Creating an account, Logging into an exisiting account, Creating a new note, Editing an existing note, Creating a file, Moving a note to the Archive, and Deleting a note.

### User Stories
[User Stories can be found here](https://github.com/EmHarris589/TakeNotesAppDev/blob/a8189b43b04e7d6259da17af9836cac735eee8c4/TakeNotes_UserStories.pdf)

### Use Cases
[Use Cases can be found here](https://github.com/EmHarris589/TakeNotesAppDev/blob/a8189b43b04e7d6259da17af9836cac735eee8c4/TakeNotes_UseCases.pdf)

### Use Case Diagram
![Use Cases Diagram](https://github.com/EmHarris589/TakeNotesAppDev/blob/a8189b43b04e7d6259da17af9836cac735eee8c4/TakeNotes_UseCaseDiagram.PNG)

## Database Design

### Chen Model Entity Relationship Diagram
![ChenERD](https://github.com/EmHarris589/TakeNotesAppDev/blob/2f8108e5857ad460ace8452761d12a8a59346aab/TakeNotes_ERD_ChenNotation.PNG)

### UML Class Diagram
![UML Class Diagram](https://github.com/EmHarris589/TakeNotesAppDev/blob/5ade8dc13405c00e8402c72f5a2bc5cd8b8ebff0/TakeNotes_ClassDiagram.PNG)

