import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { LoginData } from '../../models/login-data';
import { Observable, catchError, map } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private get apiUrl(): string {
    return environment.apiUrl;
  }
  private readonly apiContoller: string = 'api/auth';

  constructor(private _httpClient: HttpClient) {}

  login(data: LoginData): Observable<any> {
    return this._httpClient
      .post<any>(`${this.apiUrl}/${this.apiContoller}/login`, data)
      .pipe(
        map((respose) => {
          return respose;
        })
      );
  }
}
