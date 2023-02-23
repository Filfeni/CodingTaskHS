import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import Entry from 'src/app/models/Entry';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-entrydetails',
  templateUrl: './entrydetails.component.html',
  styleUrls: ['./entrydetails.component.css']
})
export class EntrydetailsComponent implements OnInit {
  
  private id: number;
  public entry: Entry;

  constructor(private router: Router, private route: ActivatedRoute, private apiService: ApiService) {
    this.id = 0;
    this.entry = {
      title:'',
      content:'',
      thumbnailContent:'',
      thumbnailUrl:'',
      creationDate: Date()
    }
  }

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.id = params['id'] || 0;
    });
    this.apiService
      .getOne<Entry>('entry',this.id)
      .subscribe(
        (entry) => (this.entry = entry)
      );
  }

  goBack():void {
    this.router.navigate(['/']);
  }

  formatDate(date: string): string {
    const options: Intl.DateTimeFormatOptions = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' }
    let result = (new Date(date)).toLocaleDateString("en-US", options);
    return result;
  }
}
