import { Component, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { ApiService } from 'src/app/services/api.service';
import Entry from 'src/app/models/Entry';
import { ImageService } from 'src/app/services/image.service';


@Component({
  selector: 'app-newentry',
  templateUrl: './newentry.component.html',
  styleUrls: ['./newentry.component.css']
})
export class  NewentryComponent implements OnInit {

  public id: number;
  private creationDate: Date;
  public thumbnailContent: string;

  constructor(private router: Router, private route: ActivatedRoute, private apiService: ApiService, private imageService: ImageService) {
    this.id = 0;
    this.creationDate = new Date();
    this.thumbnailContent = '';
  }

  public get hasId(): boolean {
    return this.id !=0;
  }

  newEntryForm = new FormGroup({
    title: new FormControl(''),
    content: new FormControl(''),
    thumbnailUrl: new FormControl('')
  });

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.id = params['id'] || 0;
    });

    if(this.id){
      this.apiService
      .getOne<Entry>('entry',this.id)
      .subscribe(
        (entry) => {
          this.newEntryForm.patchValue({...this.newEntryForm.value, title: entry.title, content: entry.content, thumbnailUrl: entry.thumbnailUrl});
          this.creationDate = new Date(entry.creationDate);
          this.thumbnailContent = entry.thumbnailContent;
        }
      );
    }
  }

  onFileSelected(event: any) {
    const selectedFile = event.target.files[0];
    this.imageService.fileToBase64(selectedFile).then(base64String => {
      this.newEntryForm.patchValue({...this.newEntryForm.value, thumbnailUrl: selectedFile.name});
      this.thumbnailContent = base64String;
    }).catch(error => {
      console.error(error);
    });
  }

  goBack():void {
    this.router.navigate(['/']);
  }

  onSubmit():void{
    const formValues = this.newEntryForm.value;
    if(this.id == 0){
      this.apiService
      .create<Entry>('entry', {
        title: formValues.title || '', 
        content: formValues.content || '', 
        thumbnailUrl: formValues.thumbnailUrl || '', 
        thumbnailContent: this.thumbnailContent, 
        creationDate: new Date().toJSON()
      })
      .subscribe(
        () => {
          this.router.navigate(['/']);
        }
      );
    } else {
      this.apiService
      .update<Entry>('entry', this.id, {
        id: this.id, title: formValues.title || '', 
        content: formValues.content || '', 
        thumbnailUrl: formValues.thumbnailUrl || '', 
        thumbnailContent: this.thumbnailContent, 
        creationDate: this.creationDate.toJSON()
      })
      .subscribe(
        () => {
          this.router.navigate(['/']);
        }
      );
    }
    
  }
}
