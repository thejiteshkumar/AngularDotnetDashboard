import { HtmlTagDefinition } from '@angular/compiler';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ThemeService {
  activeTheme: string = 'mode-dark';
  darkTheme: string = 'main-body-dark';
  lightTheme: string = 'main-body-light';

  getTheme() {
    return this.activeTheme;
  }

  setTheme(theme: string) {
    let themeLink = document.getElementById('app-theme') as HTMLLinkElement;

    var appRoot = document.getElementsByTagName('app-root') as HTMLCollection;

    if (theme === 'mode-dark') {
      appRoot[0].classList.add(this.darkTheme);
    } else {
      appRoot[0].classList.remove(this.darkTheme);
      appRoot[0].classList.add(this.lightTheme);
    }
    if (themeLink) {
      themeLink.href = theme + '.css';
    }

    this.activeTheme = theme;
  }
}
