import { Component, OnInit, inject } from '@angular/core';
import { ThemeConstant } from '../../../constants/themeConstant';
import { ThemeService } from '../../../services/theme/theme.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrl: './header.component.css',
})
export class HeaderComponent implements OnInit {
  selectedTheme: string =
    localStorage.getItem('theme') ?? ThemeConstant.ModeDark;

  checked: boolean =
    localStorage.getItem('theme') == ThemeConstant.ModeDark ? true : false;

  themService: ThemeService = inject(ThemeService);

  ngOnInit(): void {
    this.themService.setTheme(this.selectedTheme);
  }

  onThemeChange(theme: string): void {
    this.selectedTheme = theme;

    this.themService.setTheme(theme);

    localStorage.setItem('theme', theme);
  }
}
