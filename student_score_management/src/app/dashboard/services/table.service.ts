import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class TableService {
  tableHeader: string[];
  constructor() {
    this.tableHeader = [
      'Student ID',
      'Name',
      'Learning Objective',
      'Score',
      'Subject',
    ];
  }
}
