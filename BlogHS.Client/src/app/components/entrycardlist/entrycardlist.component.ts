import { Component, OnInit } from '@angular/core';
import Entry from 'src/app/models/Entry';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-entrycardlist',
  templateUrl: './entrycardlist.component.html',
  styleUrls: ['./entrycardlist.component.css']
})
export class EntrycardlistComponent implements OnInit {
  entries : Entry[] = [];
  loaded: boolean = false;

  public get entriesEmpty() : boolean {
    return this.entries.length == 0;
  }
  
  constructor(private apiService: ApiService){}

  ngOnInit(): void {
    this.apiService.getAll<Entry>('entry').subscribe((entries) => {
      this.entries = entries;
      this.loaded = true;
    });
  }

  deleteEntry(id: number) {
    this.apiService
      .delete('entry',id)
      .subscribe(
        () => (this.entries = this.entries.filter((x) => x.id !== id))
      );
  }
}
