import { TableService } from './../../services/table.service';
import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-table',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './table.component.html',
  styleUrl: './table.component.css',
})
export class TableComponent {
  tableHeader: string[];
  constructor(private tableService: TableService) {
    this.tableHeader = this.tableService.tableHeader;
  }
}
