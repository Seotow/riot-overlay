import { Input } from "./components/ui/input";
import { Button } from "./components/ui/button";
import { useEffect, useRef, useState } from "react";
// Local comparison only: never serialized to theme, transport or the OBS page.
export function ProgramMonitor({ url }: { url: string }) {
  const [image, setImage] = useState(""),
    [name, setName] = useState(""),
    [opacity, setOpacity] = useState(1),
    [error, setError] = useState("");
  const current = useRef("");
  useEffect(
    () => () => {
      if (current.current) URL.revokeObjectURL(current.current);
    },
    [],
  );
  function clear() {
    if (current.current) URL.revokeObjectURL(current.current);
    current.current = "";
    setImage("");
    setName("");
    setError("");
  }
  return (
    <>
      <div className="monitor-tools">
        <label>
          Ảnh đối chiếu
          <Input
            aria-label="Upload ảnh ingame đối chiếu"
            type="file"
            accept="image/png,image/jpeg,image/webp"
            onChange={(e) => {
              const file = e.target.files?.[0];
              e.target.value = "";
              if (!file) return;
              if (
                !["image/png", "image/jpeg", "image/webp"].includes(file.type) ||
                file.size > 20 * 1024 * 1024
              ) {
                setError("Chọn PNG/JPEG/WebP tối đa 20 MB.");
                return;
              }
              clear();
              const url = URL.createObjectURL(file);
              current.current = url;
              setImage(url);
              setName(file.name);
              setOpacity(1);
            }}
          />
        </label>
        {image && (
          <>
            <label>
              Độ hiện overlay {Math.round(opacity * 100)}%
              <Input
                aria-label="Độ hiện overlay đối chiếu"
                type="range"
                min="0"
                max="1"
                step="0.05"
                value={opacity}
                onChange={(e) => setOpacity(+e.target.value)}
              />
            </label>
            <Button onClick={clear}>Bỏ ảnh đối chiếu</Button>
            <small>{name}</small>
          </>
        )}
        {error && <span role="alert">{error}</span>}
      </div>
      <div className={`program-monitor ${image ? "has-comparison" : ""}`}>
        {image && (
          <img className="monitor-reference" src={image} alt="Ảnh ingame đối chiếu cục bộ" />
        )}
        <iframe title="Preview đầu ra OBS" src={url} style={{ opacity: image ? opacity : 1 }} />
      </div>
    </>
  );
}
