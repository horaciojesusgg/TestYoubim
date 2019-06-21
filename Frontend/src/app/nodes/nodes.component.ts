import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NgbModal,ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-nodes',
  templateUrl: './nodes.component.html',
  styleUrls: ['./nodes.component.css']
})
export class NodesComponent implements OnInit {
  uri = 'http://localhost:5000/api/nodes';
  nodes;
  closeResult: string;
  successMessage: string;
  newNodeName: string;
  newNodeVersionFile: string;
  editingNode: any;
  constructor(private http: HttpClient, private modalService: NgbModal) { }

  open(content, node) {
    if (node)
    {
      this.editingNode = node;
    }
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'}).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }

  createNode() {
    this.http.post(this.uri,{Name: this.newNodeName, VersionFile: this.newNodeVersionFile, idUser:  localStorage.getItem('user_id')}).subscribe( response => {
      this.nodes.push(response);
      this.modalService.dismissAll();
      this.successMessage = "Node Created Successfully";
    });
  }

  editNode()
  {
    this.http.put(this.uri + '/' + this.editingNode.id, {Id:this.editingNode.id , Name: this.editingNode.name, VersionFile: this.editingNode.versionFile})
    .subscribe(result => {
      this.modalService.dismissAll();
      this.successMessage = "Node Edited Successfully";
    });
  }

  deleteNode(id)
  {
    this.http.delete(this.uri + '/' + id )
    .subscribe(result => {
      this.modalService.dismissAll();
      this.successMessage = "Node Edited Successfully";
    });
  }
  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return  `with: ${reason}`;
    }
  }
  ngOnInit() {
    this.http.get(this.uri).subscribe(
      response => {
        this.nodes = response;
      }
    )
  }

}
