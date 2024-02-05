import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment.prod';
import { Student } from '../models/student.model';

@Injectable({
  providedIn: 'root'
})
export class StudentDataApiService {

  baseUrl : string;
  constructor(private http: HttpClient) {
    this.baseUrl = environment.baseUrl;
   }

   Search(keyword){
    const url = this.baseUrl + '/Students/search/' + keyword ;
    return this.http.get<Student[]>(url);
   }

   getStudentsData(){
    const url = this.baseUrl + '/Students';
    return this.http.get<Student[]>(url);
   }
}
