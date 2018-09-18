using UnityEngine;
using System.Collections.Generic;

namespace SmartLocalization
{
	public class LoadExample : MonoBehaviour
	{
		[SerializeField]
		private AudioSource _audioSource;
		
		private LanguageManager _languageManager;

		private List<SmartCultureInfo> _availableLanguages;
		private int _currentLanguageIdx;

		void Start () 
		{
			_languageManager = LanguageManager.Instance;
			
			if(_languageManager.NumberOfSupportedLanguages > 0)
				_availableLanguages = _languageManager.GetSupportedLanguages();
			else
				Debug.LogError("No languages are created!, Open the Smart Localization plugin at Window->Smart Localization and create your language!");
				
			var deviceCulture = _languageManager.GetDeviceCultureIfSupported();

			if (deviceCulture != null)
			{
				_currentLanguageIdx = _availableLanguages.FindIndex(l => l == deviceCulture);
				_currentLanguageIdx = _currentLanguageIdx < 0 ? 0 : _currentLanguageIdx;
			}
			else
			{
				Debug.Log("The device language is not available in the current application. Loading default.");
			}

			_languageManager.ChangeLanguage(_availableLanguages[_currentLanguageIdx]);
			
			_audioSource.clip = _languageManager.GetAudioClip("Anthem");
			_audioSource.Play();
		}
	
		public void OnNextLanguage()
		{
			_currentLanguageIdx = (_currentLanguageIdx + 1) % _availableLanguages.Count;
			_languageManager.ChangeLanguage(_availableLanguages[_currentLanguageIdx]);
			
			_audioSource.clip = _languageManager.GetAudioClip("Anthem");
			_audioSource.Play();
		}
	}
}
