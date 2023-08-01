import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { user } from './Models/users';
import { environment } from 'src/environments/environment';

@Injectable(
  // providedIn: 'root'
)
export class UsersService {
  readonly url = "http://localhost:5232/"
  constructor(private http:HttpClient) { }

  public postData(User: any): Observable<any> {
    return this.http.post(this.url,User);
    // (`${environment.apiUrl}Admin/UserLogin`,  data );

  }
}
