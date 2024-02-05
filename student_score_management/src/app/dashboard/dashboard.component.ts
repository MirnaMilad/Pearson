import { Component } from '@angular/core';
import { SearchBarComponent } from './components/search-bar/search-bar.component';
import { TableComponent } from './components/table/table.component';
import { Student } from './models/student.model';
import { StudentDataApiService } from './services/student-data-api.service';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [SearchBarComponent, TableComponent],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css',
})
export class DashboardComponent {
  studentData: Student[];

  constructor(private studentDataApiService: StudentDataApiService) {
    this.getStudentsData();
  }

  getStudentsData() {
    this.studentDataApiService
      .getStudentsData()
      .subscribe((res) => (this.studentData = res));
  }

  Search(keyword) {
    this.studentDataApiService
      .Search(keyword)
      .subscribe((res) => (this.studentData = res));
  }
}
