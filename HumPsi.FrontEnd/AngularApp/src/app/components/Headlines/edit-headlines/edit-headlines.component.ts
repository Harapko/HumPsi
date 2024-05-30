import { Component, OnInit } from '@angular/core';
import {FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators} from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { DialogModule } from 'primeng/dialog';
import { CommonModule } from '@angular/common';
import { ButtonModule } from 'primeng/button';
import { HeadlinesService } from '../../../services/navMenu/headlines.service';

@Component({
  selector: 'app-edit-headlines',
  standalone: true,
  imports: [
    FormsModule,
    DialogModule,
    CommonModule,
    ButtonModule,
    ReactiveFormsModule
  ],
  templateUrl: './edit-headlines.component.html',
  styleUrls: ['./edit-headlines.component.scss']
})
export class EditHeadlinesComponent implements OnInit {
  sectionId!: string | null;
  selectedFile: File | null = null;
  headlineForm!: FormGroup;
  constructor(
    private route: ActivatedRoute,
    private headlineService: HeadlinesService
  ) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
      this.sectionId = params.get('sectionId');
      this.initForm();  // Инициализация формы после получения sectionId
    });
  }

  private initForm() {
    this.headlineForm = new FormGroup({
      sectionId: new FormControl(`${this.sectionId}`, Validators.required),
      title: new FormControl('', [Validators.required, Validators.minLength(3)]),
      filePath: new FormControl('', Validators.required)
    });
  }

  onFileChange(event: any): void {
    if (event.target.files.length > 0) {
      this.selectedFile = event.target.files[0];
    }
  }

  onSubmit(): void {
    if (this.headlineForm.valid) {
      const formData = new FormData();
      formData.append('sectionId', this.headlineForm.get('sectionId')?.value || '');
      formData.append('title', this.headlineForm.get('title')?.value || '');
      if (this.selectedFile) {
        formData.append('filePath', this.selectedFile);
      }

      this.headlineService.createHeadlines('http://localhost:5198/createHeadlines', formData).subscribe(
        response => {
          console.log('Data sent successfully', response);
        },
        error => {
          console.error('Error sending data', error);
        }
      );
    } else {
      console.error('Form is not valid');
    }
  }



// createHeadlines(headlines: Headlines){
  //   this.headlineService.createHeadlines(`http://localhost:5198/createHeadlines`, headlines).subscribe({
  //     next: (data) => {
  //       console.log(data)
  //     },
  //     error: (error) => {
  //       console.log(error)
  //     }
  //   })
  // }
  //
  // editHeadlines(headlines: Headlines, id: string){
  //   this.headlineService.editHeadline(`http://localhost:5198/editHeadlines/${id}`, headlines).subscribe({
  //     next: (data) => {
  //       console.log(data)
  //     },
  //     error: (error) =>{
  //       console.log(error)
  //     }
  //   })
  // }

  protected readonly FormGroup = FormGroup;
}


