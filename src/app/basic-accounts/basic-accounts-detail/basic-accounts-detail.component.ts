import { Component } from '@angular/core';
import {RouterLink} from "@angular/router";

@Component({
  selector: 'app-basic-accounts-detail',
  standalone: true,
    imports: [
        RouterLink
    ],
  templateUrl: './basic-accounts-detail.component.html',
  styleUrl: './basic-accounts-detail.component.css'
})
export class BasicAccountsDetailComponent {

}
