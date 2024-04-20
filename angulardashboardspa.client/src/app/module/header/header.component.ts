import { Component, OnInit, inject } from '@angular/core';
import { ThemeService } from '../../services/theme.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrl: './header.component.css',
})
export class HeaderComponent implements OnInit {
  
  checked: boolean = true;
  selectedTheme: string = 'mode-dark';
  themService: ThemeService = inject(ThemeService);

  ngOnInit(): void {
    this.themService.setTheme(this.selectedTheme);
  }

  onThemeChange(theme: string): void{
    this.selectedTheme = theme;
    this.themService.setTheme(theme);
  }
}
