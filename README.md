# Smart Localization 3

In comparison with original Smart Localization 2, developed by Niklas Borglund & Jakob Hillerström this fork have some advantages:

-Unity 2018.2 full support  
-TextMesh Pro support  
-Sprite loading from resources  
-UI.Image component  
-Sprite component  
-For greater experience you can choose localizations for a certain item in Inspector  
-Legacy code removed  
-New example scene  

# Instalation

Please visit [Releases Page](https://github.com/chocolacula/SmartLocalization3/releases) where you can get .unitypackage for Unity 2018.2 or download and import Assets/SmartLocalization folder if yor Unity version is lower then 2018 (don't forget import TextMesh Pro from Asset Store). 

# Instruction

Localizing your game has never been this easy. Localize your game with only a few mouse clicks.

Just open the Smart Localization Window in Window->Smart Localization and start by pressing 
"Create new localization system".
Edit the root language file by adding some keys and base values.

To add a new language to your project, choose a language in the "Add/Update Languages" panel and click "Create".
To edit and translate a language, press the "Translate" button on the language you want to work with in the Created Languages panel.

# Code Examples

```csharp
//Returns a text value in the current language for the key
string myKey = LanguageManager.Instance.GetTextValue("MYKEY");
```
```csharp
//Gets the audio clip for the current language
AudioClip myClip = LanguageManager.Instance.GetAudioClip("MYKEY"); 
```
```csharp
//Gets the prefab game object for the current language
GameObject myPrefab = LanguageManager.Instance.GetPrefab("MYKEY");
```
```csharp
//Gets the texture for the current language
Texture myTexture = LanguageManager.Instance.GetTexture("MYKEY");
```
```csharp
//(Pro feature)Gets a localized TextAsset
TextAsset myTextAsset = LanguageManager.Instance.GetTextAsset("MYKEY");
```
```csharp
//To cache the LanguageManager in a variable
LanguageManager languageManager = LanguageManager.Instance;
```
```csharp
//Get a list of all the available languages
List<SmartCultureInfo> availableLanguages = thisLanguageManager.GetSupportedLanguages();
```
```csharp
Get the smart culture info of the system language if it is supported. otherwise it will return null
SmartCultureInfo systemLanguage = thisLanguageManager.GetSupportedSystemLanguage();
```
```csharp
//Check if a language is supported with an ISO-639 language code (string = "en" "sv" "es" etc.)
LanguageManager.Instance.IsLanguageSupported("en");
```
```csharp
//Check if a language is supported with an instance of SmartCultureInfo
SmartCultureInfo swedishCulture = new SmartCultureInfo("sv", "Swedish", "Svenska", false);
LanguageManager.Instance.IsLanguageSupported(swedishCulture);
```
```csharp
//Change a language with an ISO-639 language code ("en" "sv" "es" etc., Make sure the language is supported)
LanguageManager.Instance.ChangeLanguage("en");
```
```csharp
//Change the language with a SmartCultureInfo instance
SmartCultureInfo swedishCulture = new SmartCultureInfo("sv", "Swedish", "Svenska", false);
LanguageManager.Instance.ChangeLanguage(swedishCulture);
```
```csharp
//How to register on the event that fires when a language changed
LanguageManager.Instance.OnChangeLanguage += OnLanguageChanged; //OnLanguageChanged = delegate method that you created
```
```csharp
//Enable extensive debug logging
LanguageManager.Instance.VerboseLogging = true;
```
```csharp
//Check if a localized key exists
LanguageManager.Instance.HasKey("myKey")
```
