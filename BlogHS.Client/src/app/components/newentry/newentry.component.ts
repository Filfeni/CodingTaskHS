import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-newentry',
  templateUrl: './newentry.component.html',
  styleUrls: ['./newentry.component.css']
})
export class NewentryComponent {
  newEntryForm = new FormGroup({
    title: new FormControl(''),
    content: new FormControl(''),
  });

  onSubmit():void{

  }
}
