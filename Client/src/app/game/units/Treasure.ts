import { GameUnit } from '../bases/GameUnit';
import { GameScene } from '../bases/GameScene';

export class Treasure extends GameUnit {
    private meshes: BABYLON.AbstractMesh[];
    private timer = 0;

    constructor(scene: GameScene, name: string) {
        super(scene, name);
    }

    onCreate() {
        BABYLON.SceneLoader.ImportMesh('', './assets/', 'bitcoin.babylon', this.scene.core,
            (newMeshes, particleSystems, skeletons) => {
                this.meshes = newMeshes;

                this.meshes.forEach(mesh => {
                    mesh.parent = this;
                    mesh.material = new BABYLON.PBRMetallicRoughnessMaterial('pbr', this.scene.core);
                });
            });
    }

    onUpdate() {
        this.position.y = 3 * Math.sign(this.timer);
        this.timer += 0.01;
    }
}
