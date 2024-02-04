import { StudentDataApiService } from './../../services/student-data-api.service';
import { TableService } from './../../services/table.service';
import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { Student } from '../../models/student.model';

@Component({
  selector: 'app-table',
  standalone: true,
  imports: [CommonModule , HttpClientModule],
  templateUrl: './table.component.html',
  styleUrl: './table.component.css',
})
export class TableComponent {
  tableHeader: string[];
  studentData: Student[];
  constructor(
    private tableService: TableService,
    private studentDataApiService: StudentDataApiService
  ) {
    this.tableHeader = this.tableService.tableHeader;
    this.getStudentsData();
  }

  getStudentsData() {
    this.studentDataApiService.getStudentsData().subscribe(
      res=>this.studentData = res
    )
  }
}
