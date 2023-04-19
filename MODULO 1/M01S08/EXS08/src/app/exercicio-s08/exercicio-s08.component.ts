import { Component, OnInit } from '@angular/core';
import { PersonagemClass } from '../personagem-class';
import { PersonagensStarWarsService } from '../personagens-star-wars.service';

@Component({
  selector: 'app-exercicio-s08',
  templateUrl: './exercicio-s08.component.html',
  styleUrls: ['./exercicio-s08.component.css'],
})
export class ExercicioS08Component implements OnInit {
  public personagens: PersonagemClass[] = [];
  constructor(private _service: PersonagensStarWarsService) {}

  ngOnInit(): void {
    this._service.getPersonagens().subscribe((res) => {
      this.personagens = res;
    });
  }
  public getPersonagensFromService() {}
}
