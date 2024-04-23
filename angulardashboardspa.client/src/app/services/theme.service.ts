import { Injectable } from '@angular/core';
import { ThemeConstant } from '../constants/themeConstant';

@Injectable({
  providedIn: 'root',
})
export class ThemeService {
  activeTheme: string = ThemeConstant.ActiveTheme;

  getTheme() {
    return this.activeTheme;
  }

  setTheme(theme: string) {
    let themeLink = document.getElementById('app-theme') as HTMLLinkElement;

    var appRoot = document.getElementsByTagName('app-root') as HTMLCollection;
    var sunIcon = document.getElementById('sun-icon') as HTMLElement;
    var moonIcon = document.getElementById('moon-icon') as HTMLElement;

    if (theme === 'mode-dark') {
      appRoot[0].classList.add(ThemeConstant.DarkTheme);

      sunIcon.classList.add(ThemeConstant.SunDark);
      moonIcon.classList.add(ThemeConstant.MoonDark);
    }
    else {
      appRoot[0].classList.remove(ThemeConstant.DarkTheme);
      appRoot[0].classList.add(ThemeConstant.LightTheme);
      
      //Removing light theme
      sunIcon.classList.remove(ThemeConstant.SunDark);
      moonIcon.classList.remove(ThemeConstant.MoonDark);

      //Adding dark theme
      sunIcon.classList.add(ThemeConstant.SunLight);
      moonIcon.classList.add(ThemeConstant.MoonLight);

    }
    if (themeLink) {
      themeLink.href = theme + '.css';
    }

    this.activeTheme = theme;
  }

}


