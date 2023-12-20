# Misharp

Yet Another Misskey Library For C#

## Dependedencies Library

* System.Text.Json

## Supported Environment

* Net6.0+

## Supported Endpoints

|status|meaning|
|---|---|
|〇|working|
|△|not working check|
|×|not support(yet)|

|name|supported|
|---|---|
|Admin|△|
|Announcements|△|
|Antennas|△|
|Ap|×|
|App|△|
|Auth|△|
|Blocking|△|
|Channels|△|
|Charts|×|
|Clips|△|
|Drive|△|
|Email-Address|△|
|Emoji|〇|
|Emojis|〇|
|Endpoint|×|
|Endpoints|△|
|Federation|△|
|Fetch-External-Resources|×|
|Fetch-Rss|△|
|Flash|△|
|Following|△|
|Gallery|△|
|Get-Avatar-Decoration|△|
|Get-Online-Users-Count|×|
|Hashtags|△|
|I|△|
|Invite|△|
|Meta|△|
|Mute|△|
|My|△|
|Notes|△|
|Notifications|×|
|Pages|△|
|Ping|〇|
|Pinned-Users|△|
|Promo|△|
|Renote-Mute|△|
|Request-Reset-Password|×|
|Reset-Password|×|
|Retention|×|
|Roles|△|
|Server-Info|×|
|Stats|△|
|Sw|△|
|Test|×|
|Username|△|
|Users|△|

## Example

Tips: Get token with browser option will be add.

### How to get Token?

<https://misskey-hub.net/en/docs/api#getting-an-access-token>

### Post note

```csharp
var app = new App("misskey.04.si", "abcdef123...");
var note = await app.NotesApi.Create(text: "Hello world");
Console.WriteLine(note.ToString());
```

### Post note with file

```csharp
var app = new App("misskey.04.si", "abcdef123...");
var file = await app.DriveApi.FilesApi.Create(File.OpenRead(@"img.png"));
var note = await app.NotesApi.Create(text: "hello world", fileIds: new List<string> { file.Id });
Console.WriteLine(note.ToString());
```

### Get my user info

```csharp
var app = new App("misskey.04.si", "abcdef123...");
var user = await app.IApi.I();
Console.WriteLine(user.ToString());
```

### Get note info

```csharp
var app = new App("misskey.04.si", "abcdef123...");
var note = await app.NotesApi.Show("zyxwv987...");
Console.WriteLine(note.ToString());
```
