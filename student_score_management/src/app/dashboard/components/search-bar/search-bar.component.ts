import { FormsModule, NgForm } from '@angular/forms';
import { Student } from '../../models/student.model';
import {
  Component,
  EventEmitter,
  Output
} from '@angular/core';

@Component({
  selector: 'app-search-bar',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './search-bar.component.html',
  styleUrl: './search-bar.component.css',
})
export class SearchBarComponent {
  @Output() keyword = new EventEmitter<string>();
  students: Student[];
  searchWord;

  search() {
    this.keyword.emit(this.searchWord);
  }
}
