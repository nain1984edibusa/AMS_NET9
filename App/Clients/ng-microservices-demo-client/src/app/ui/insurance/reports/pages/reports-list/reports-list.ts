import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { MatTableModule } from '@angular/material/table';

@Component({
  selector: 'app-reports-list',
  standalone: true,
  imports: [CommonModule, MatTableModule],
  templateUrl: './reports-list.html',
})
export class ReportsList {
  displayedColumns: string[] = ['cedula', 'apellidos', 'nombres'];

  dataSource = [
    { cedula: '0102030405', apellidos: 'Bustillos Tapia', nombres: 'Eduardo Andrés' },
    { cedula: '0607080910', apellidos: 'Tapia Cueva', nombres: 'Freddy Rolando' },
    { cedula: '1101121314', apellidos: 'García León', nombres: 'María Elena' }
  ];
}
