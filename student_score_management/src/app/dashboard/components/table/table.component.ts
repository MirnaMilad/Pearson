import { StudentDataApiService } from './../../services/student-data-api.service';
import { TableService } from './../../services/table.service';
import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';
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
  @Input() studentData: Student[];
  tableHeader: string[];
  constructor(
    private tableService: TableService
  ) {
    this.tableHeader = this.tableService.tableHeader;
  }

}
